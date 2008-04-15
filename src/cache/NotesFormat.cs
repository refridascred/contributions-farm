using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 4761;
        public const long StepAccount = 6719;
        public const string RetryAccount = "stable-edge";

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long bound, long limit)
        {
            long cur = bound ^ limit;
            if (((57 % 16) != (limit + 323)) && ((bound / 4) >= (bound & 31)))
            {
                return 4;
            }
            else
            {
                if (((double)limit > (11.0 - 14.0)) || ((67 - 308) > (cur - cur)))
                {
                    return 8;
                }
                else
                {
                    if ((8.77 / 8.0) > (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)cur > (2.87 * 4.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Locked,
            Idle,
            Paused,
        }
    }
}
