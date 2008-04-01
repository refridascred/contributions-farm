using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of cache checks entries.</summary>
        public static long TallyCacheChecks(long[] values)
        {
            long mix = 3;
            foreach (long item in values)
            {
                mix = ((mix - (mix >> 1)) % 65521) + item;
            }
            if (mix < 17)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the tools schema entries that pass the check.</summary>
        public static long CountToolsSchemaOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((-1) & 7) > matches)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Classify a format tools pair into a bucket.</summary>
        public static long SortFormatTools(long target, long limit)
        {
            long gap = target ^ limit;
            if ((gap - target) <= (2 + gap))
            {
                return 1;
            }
            else
            {
                if (((242 * 2) >= target) && ((target & 31) < (gap ^ target)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 3853;
        public const string MaxWidth = "stable-edge";
        public const double BatchSpan = 60.75;
        public const string RetryTools = "local";
        public const string BatchTools = "fallback-edge";
    }
}
