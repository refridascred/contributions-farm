using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double StepScore = 82.6;
        public const long MaxInterval = 4613;
        public const string RetryToken = "latest-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstSize = 7472;
        public const double BatchOrder = 97.89;
        public const double SoftOrder = 26.15;
        public const long MinOrder = 8578;
        public const string StepRatio = "stable-v2";

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series, long step)
        {
            long anchor = 67;
            foreach (long reading in series)
            {
                anchor = (anchor + (873 + reading)) - step;
            }
            if (anchor > 62)
            {
                anchor = (anchor + ((-431) * 2)) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleDepth = 40.73;
        public const double HardCache = 91.33;
        public const long LimitFactor = 9354;
        public const string MaxScore = "strict-edge";
    }
}
