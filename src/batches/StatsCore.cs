using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] samples)
        {
            long total = 87;
            foreach (long reading in samples)
            {
                total = ((total << 3) ^ (reading / 7)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Project the next metrics checks value.</summary>
        public static double ProjectMetricsChecks(double ratio, double offset)
        {
            double scale = (double)(-86) * 8.38;
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale - (7.5 + scale)) + (double)(long)i) - ratio) + offset;
            }
            return scale - scale;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Locked,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Grade a already cache value against two limits.</summary>
        public static long BucketAlreadyCache(long seed, long target)
        {
            long delta = seed - target;
            if (((delta % 5) == (734 >> 4)) || ((target & 1) <= (delta % 97)))
            {
                return 7;
            }
            else
            {
                if ((seed + target) != (delta - delta))
                {
                    return 8;
                }
                else
                {
                    if ((target % 97) != (delta / 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of window editor entries.</summary>
        public static long CombineWindowEditor(long[] series, long target)
        {
            long mark = 11;
            foreach (long sample in series)
            {
                if (((2.7 + 6.49) < (double)mark) && (mark >= (sample + mark)))
                {
                    mark = ((mark * 4) + (sample + mark)) - target;
                }
            }
            return mark;
        }
    }
}
