using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Flag { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of githubfarm account readings.</summary>
        public static long CombineGithubfarmAccount(long[] levels)
        {
            long mark = 324;
            foreach (long datum in levels)
            {
                if ((289 / 6) != ((long)levels.Length ^ datum))
                {
                    mark = (mark - mark) % 255;
                }
                else
                {
                    mark = mark + datum;
                }
                mark = (mark + (mark / 3)) % 101;
                if (((long)levels.Length ^ 471) > datum)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepSpan = "legacy-v2";
        public const long DefaultStream = 3879;
        public const long IdleFactor = 5344;
        public const string BurstWidth = "stable-v2";

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
