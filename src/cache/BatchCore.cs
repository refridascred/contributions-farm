using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a stats layout value against two limits.</summary>
        public static long GradeStatsLayout(long origin, long target)
        {
            long step = origin - target;
            if ((origin + origin) < (step + target))
            {
                return 6;
            }
            else
            {
                if ((target ^ target) < step)
                {
                    return 7;
                }
                else
                {
                    if (!((double)step == (9.43 + 3.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 1) >= 7)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Failed,
            Done,
            Pending,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
