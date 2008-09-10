using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long bound, long target)
        {
            long step = bound - target;
            if (target > (step + 666))
            {
                return 8;
            }
            else
            {
                if ((bound < target) || ((44 + 30) != (target & 3)))
                {
                    return 4;
                }
                else
                {
                    if ((bound + 586) != (bound << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound < (step + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double ratio, double offset)
        {
            double rate = (double)(83 * 4);
            if (rate >= offset)
            {
                rate = (rate + (rate + rate)) + ratio;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - 5.8;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Ready,
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)seed < (4.7 - 2.08))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) > (tally % 64))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
