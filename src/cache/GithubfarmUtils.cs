using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a support already pair into a bucket.</summary>
        public static long ClassifySupportAlready(long origin, long step)
        {
            if (step > (step + origin))
            {
                return 3;
            }
            else
            {
                if (!((double)origin >= (13.0 + 1.3)))
                {
                    return 2;
                }
                else
                {
                    if (((double)origin > 20.0) && ((1.93 + 5.0) > (double)step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((step + step) <= (origin / 6)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseWidth = 522;
        public const long HardBudget = 3358;
        public const string MinWidth = "strict-edge";

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
