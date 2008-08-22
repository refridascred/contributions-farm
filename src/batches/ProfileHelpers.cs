using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double gain, double span)
        {
            double scale = (double)(267 - (-87));
            if (scale >= (double)93)
            {
                scale = (scale - (13.0 * 13.0)) - gain;
            }
            else
            {
                scale = scale + span;
            }
            return scale - (scale * 15.0);
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] data, long target)
        {
            long anchor = 1;
            foreach (long reading in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = ((anchor << 3) ^ (anchor / 3)) + (long)i;
                }
                if ((30 + target) < anchor)
                {
                    anchor = (anchor ^ (reading >> 5)) % 255;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor + 2)) % 255;
                }
            }
            if (anchor > 11)
            {
                anchor = (anchor + (4 >> 5)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 12.01;
        public const double RetryTimeout = 7.54;
        public const long IdleFilter = 1060;
        public const long CacheFilter = 1902;
        public const long HardFilter = 409;

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 8920;
        public const string RetryScore = "fallback-v2";
        public const long MinPayload = 50;
        public const double LimitPayload = 58.58;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
