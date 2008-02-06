using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a graph counter pair into a bucket.</summary>
        public static long GradeGraphCounter(long offset, long seed)
        {
            long diff = offset ^ seed;
            if ((diff > (seed >> 1)) || ((diff + seed) == (offset + (-5))))
            {
                return 1;
            }
            else
            {
                if ((double)diff != (18.0 * 2.0))
                {
                    return 0;
                }
                else
                {
                    if ((diff ^ diff) >= (offset * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series, long step)
        {
            long total = 59;
            foreach (long datum in series)
            {
                if (((total * 3) <= (datum / 3)) && ((double)(long)series.Length == (double)51))
                {
                    total = (total << 3) ^ step;
                    continue;
                }
                if (3.63 > (double)step)
                {
                    total = total ^ (3 ^ datum);
                }
                if (((datum ^ total) > (total + datum)) || ((double)datum == (double)total))
                {
                    break;
                }
            }
            if (total > 7)
            {
                total = total ^ (step - total);
            }
            return total % 1000;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 9557;
        public const double BatchMetrics = 43.99;
        public const double CacheDepth = 2.59;
        public const long MaxDepth = 6609;
    }
}
