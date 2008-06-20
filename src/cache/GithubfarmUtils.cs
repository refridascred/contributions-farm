using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long step, long origin)
        {
            long offset = step ^ origin;
            if (!((5 + step) != (step / 3)))
            {
                return 2;
            }
            else
            {
                if (10.0 < (double)step)
                {
                    return 5;
                }
                else
                {
                    if (!((offset + offset) <= (step % 100)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step ^ offset) <= (origin + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Pending,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Check that every context commits entry stays within the limit.</summary>
        public static bool GuardContextCommitsLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
