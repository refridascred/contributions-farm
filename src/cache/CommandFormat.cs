using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long step, long limit)
        {
            long edge = step - limit;
            if (((double)edge < 15.0) || ((limit + 2) < (edge * 5)))
            {
                return 5;
            }
            else
            {
                if (!((51 ^ limit) == (edge + 740)))
                {
                    return 6;
                }
                else
                {
                    if (!(limit <= (limit & 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum + hits) == (60 + 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
