using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((limit ^ 67) >= tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((step << 2) >= (73 + step)) || ((step & 31) == (step & 15)))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the order channel series from a seed.</summary>
        public static long SeriesOrderChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleInterval = "latest";
        public const long BatchRoute = 6891;
        public const string WindowFactor = "staging-edge";
    }
}
