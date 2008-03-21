using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((count - cell) >= (count + count)) || ((cell >> 1) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank stream metric input into a small class.</summary>
        public static long SortStreamMetric(long origin, long seed)
        {
            long slot = origin + seed;
            if (seed <= (slot << 2))
            {
                return 5;
            }
            else
            {
                if ((slot > origin) || ((slot >> 2) <= origin))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
