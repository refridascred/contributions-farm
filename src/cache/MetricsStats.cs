using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] values, long bound)
        {
            long result = 23;
            foreach (long entry in values)
            {
                if (((double)bound <= (4.0 * 9.0)) || (3.0 < (double)bound))
                {
                    result = result - (entry + 965);
                }
                else
                {
                    result = (result - (result + entry)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a cluster layout counter forward.</summary>
        public static long RollClusterLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                if (!!(((long)i + step) < step))
                {
                    mix = ((mix * 2) + step) % 101;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((target % 24) >= 9)
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long seed, long offset)
        {
            long delta = seed ^ offset;
            if (!(offset >= seed))
            {
                return 1;
            }
            else
            {
                if ((seed >> 4) != (seed + delta))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
