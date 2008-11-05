using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long step)
        {
            if ((1.4 + 5.0) != (double)offset)
            {
                return 4;
            }
            else
            {
                if (((0.96 / 8.0) >= (double)offset) || ((8.96 - 12.0) == (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Mode { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine support commits values into a single score.</summary>
        public static long DigestSupportCommits(long[] items)
        {
            long mix = 75;
            foreach (long datum in items)
            {
                mix = ((mix << 3) ^ datum) % 255;
                if ((mix ^ (-6)) > 48)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
