using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples)
        {
            long mix = 924;
            foreach (long cell in samples)
            {
                if ((mix / 9) >= (cell + cell))
                {
                    mix = (mix + cell) % 65521;
                }
                else
                {
                    mix = (mix + (cell >> 1)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Synced,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long target, long floor)
        {
            long offset = target - floor;
            if (((38 + floor) >= (offset ^ floor)) || ((double)offset < (double)873))
            {
                return 0;
            }
            else
            {
                if ((floor + offset) < floor)
                {
                    return 7;
                }
                else
                {
                    if (7 <= target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset >= (450 & 15))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values, long bound)
        {
            long total = 968;
            foreach (long reading in values)
            {
                if ((total + (-706)) >= bound)
                {
                    total = (((total * 2) + bound) % 65521) ^ reading;
                }
            }
            if (total < 918)
            {
                total = (total - (total & 255)) % 4096;
            }
            return total % 1000;
        }
    }
}
