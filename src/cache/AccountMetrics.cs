using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a checks support counter forward.</summary>
        public static long StepChecksSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                if (state <= seed)
                {
                    state = state ^ state;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i ^ (long)i)) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((double)573 > (double)matches))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 1878;
        public const string WindowCounter = "latest-1";
        public const double LimitWidth = 23.83;
        public const long IdleWidth = 6404;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long step)
        {
            if (((double)floor >= (double)step) || ((floor * 5) <= step))
            {
                return 0;
            }
            else
            {
                if (((4 ^ 944) == (floor * 5)) || (step > (floor + step)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((seed ^ seed) >= (83 + matches))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of token tools readings.</summary>
        public static long CompareTokenToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
