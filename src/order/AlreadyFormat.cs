using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a editor schema counter forward.</summary>
        public static long RollEditorSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                if ((carry ^ carry) != ((long)i - carry))
                {
                    carry = (carry - (target + carry)) % 65521;
                }
                else
                {
                    carry = ((carry * 5) + ((long)i & 127)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Locate a cluster contributi reading by value.</summary>
        public static long LocateClusterContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            New,
            Failed,
            Done,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
