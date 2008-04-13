using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up command batches samples.</summary>
        public static long CompareCommandBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a tools metrics sample.</summary>
        public static long LocateToolsMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
