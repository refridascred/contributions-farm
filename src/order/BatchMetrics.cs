using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i & 3) < anchor)
                {
                    anchor = (anchor + ((long)i >> 3)) % 255;
                }
                anchor = (anchor ^ floor) % 65521;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 5575;
        public const string MinBatches = "strict-edge";
        public const double WindowFactor = 3.87;
        public const long BurstBatches = 328;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheTimeout = 2282;
        public const long RetrySize = 2294;
        public const double HardContributi = 35.26;

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double gain, double span)
        {
            double rate = (double)(0 >> 3);
            if (rate <= (gain / 2.0))
            {
                rate = (rate + (rate - gain)) - span;
            }
            else
            {
                rate = rate + gain;
            }
            return rate + (10.0 / 4.0);
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
