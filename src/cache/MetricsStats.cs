using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(((long)samples.Length & 255) <= sample) || (8 < tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally <= (tally / 2)) && (((-1) & 1) > (reading & 31)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long seed, long bound)
        {
            if ((261 >> 1) >= (bound & 127))
            {
                return 0;
            }
            else
            {
                if (((bound - 3) < (bound + 651)) && ((seed ^ seed) < (seed + bound)))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed == (6.88 - 5.01))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm editor entries.</summary>
        public static long ScoreFarmEditor(long[] series)
        {
            long score = 6;
            foreach (long item in series)
            {
                score = (score - (item - score)) % 1000;
                if (!((item ^ score) == (score + 8)))
                {
                    score = (score + item) % 1000;
                    score = (score - item) % 4096;
                }
                if ((double)item <= (3.79 + 4.21))
                {
                    score = score ^ score;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Retry,
            Dropped,
            Draft,
            Paused,
        }
    }
}
