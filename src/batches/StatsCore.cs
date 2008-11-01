using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double mean = scale;
            if (mean > mean)
            {
                mean = (mean + (scale / 9.0)) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)590) + (double)(long)i;
            }
            return mean - (mean - mean);
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long origin, long target)
        {
            long diff = origin - target;
            if (((2.6 * 1.4) == (double)diff) || ((origin & 63) > (target << 1)))
            {
                return 8;
            }
            else
            {
                if (origin <= (target / 8))
                {
                    return 0;
                }
                else
                {
                    if ((origin ^ diff) < (diff ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target != (6.73 + 3.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Locked,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Flag { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
        }
    }
}
