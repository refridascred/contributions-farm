using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long origin, long origin2)
        {
            long edge = origin - origin2;
            if ((origin + origin2) < (origin - origin2))
            {
                return 2;
            }
            else
            {
                if (origin2 <= (origin2 + (-217)))
                {
                    return 0;
                }
                else
                {
                    if ((109 * 2) <= origin2)
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin2 < edge)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
