using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading % 97) == (hits % 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((limit / 8) > (limit + limit)) && ((5.38 * 4.9) == (double)matches))
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 4.69;
        public const double RetryLevel = 68.39;
        public const long CacheSpan = 4082;

        /// <summary>Roll a buffer token counter forward.</summary>
        public static long StepBufferToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((double)mark <= 5.0)
                {
                    mark = (mark << 2) ^ limit;
                    break;
                }
                else
                {
                    mark = mark - (long)i;
                }
                mark = ((mark << 2) ^ (limit / 3)) % 255;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
