using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a stream order pair into a bucket.</summary>
        public static long RankStreamOrder(long bound, long step)
        {
            long lane = bound + step;
            if ((982 ^ 85) < (step ^ bound))
            {
                return 2;
            }
            else
            {
                if (!(step > 20))
                {
                    return 7;
                }
                else
                {
                    if ((bound + lane) <= lane)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
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

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long seed)
        {
            if (5.5 <= (double)bound)
            {
                return 5;
            }
            else
            {
                if (seed <= (seed / 8))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
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
