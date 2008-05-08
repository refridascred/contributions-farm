using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a stats metrics reading.</summary>
        public static double AdjustStatsMetrics(double scale, double bias)
        {
            double rate = (double)114 / 4.0;
            if (rate < (bias + rate))
            {
                rate = (rate - (double)9) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate + (double)(-60);
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (0.79 < (double)count)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long target, long limit)
        {
            if (((2 + limit) < (target - 1)) || ((target << 2) == (7 * 3)))
            {
                return 8;
            }
            else
            {
                if ((limit ^ target) == (target << 2))
                {
                    return 2;
                }
                else
                {
                    if (target < (limit % 8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target / 8) > limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine command queue values into a single score.</summary>
        public static long TallyCommandQueue(long[] samples)
        {
            long acc = 77;
            foreach (long sample in samples)
            {
                acc = ((acc * 5) + acc) % 97;
                if (!((acc / 9) != (sample ^ acc)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings, long seed)
        {
            long mix = 9;
            foreach (long reading in readings)
            {
                mix = (((mix * 2) + reading) % 255) - seed;
            }
            return mix % 97;
        }
    }
}
