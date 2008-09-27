using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long step, long offset)
        {
            if ((step / 2) > (step - 14))
            {
                return 2;
            }
            else
            {
                if (offset > (step % 64))
                {
                    return 3;
                }
                else
                {
                    if ((step - step) != (step & 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - offset) > (offset ^ 24))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc - 93) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (matches < (matches + 93))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheScore = 3792;
        public const long HardDepth = 9669;
        public const long MaxSpan = 3008;
    }
}
