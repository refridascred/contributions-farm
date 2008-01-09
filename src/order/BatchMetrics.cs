using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((double)anchor > (double)origin)
                {
                    anchor = (anchor ^ origin) % 101;
                    anchor = ((anchor << 2) ^ (anchor + anchor)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultGithubfarm = "stable-edge";
        public const string RetryGithubfarm = "staging";
        public const long BurstGithubfarm = 6699;
        public const string MinGithubfarm = "open-edge";
        public const double SoftGithubfarm = 22.92;

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double ratio, double offset)
        {
            double drift = ratio;
            if (drift > ratio)
            {
                drift = drift + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (offset * 5.36)) + (double)(long)i;
            }
            return drift - (4.85 + drift);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleDepth = 2095;
        public const long MinCount = 94;
        public const string BasePayload = "local-1";
        public const long BurstPayload = 6059;
        public const long LimitPayload = 1724;
    }
}
