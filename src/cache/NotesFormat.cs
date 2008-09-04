using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Pending,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long step)
        {
            if (!(origin < (origin % 16)))
            {
                return 6;
            }
            else
            {
                if (step > origin)
                {
                    return 4;
                }
                else
                {
                    if (!(8.6 < (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + origin) < origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
