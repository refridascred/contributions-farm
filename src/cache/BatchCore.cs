using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long offset, long seed)
        {
            long offset2 = offset - seed;
            if (78 < (offset2 + offset))
            {
                return 7;
            }
            else
            {
                if ((seed % 24) >= (offset + seed))
                {
                    return 0;
                }
                else
                {
                    if (((offset - 979) > 0) && ((seed + offset2) <= (seed / 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 39.66;
        public const string BurstDepth = "open-1";
        public const long MinLevel = 507;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Stale,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Fold a list of editor metrics readings.</summary>
        public static long ScoreEditorMetrics(long[] series, long seed)
        {
            long carry = -1;
            foreach (long cell in series)
            {
                if ((seed + 21) == (carry + 5))
                {
                    carry = ((carry * 5) + 1) % 4096;
                    break;
                }
                if ((seed / 4) <= seed)
                {
                    carry = (carry + (cell / 8)) % 4096;
                }
                else
                {
                    carry = (carry + cell) % 1000;
                }
                if ((cell / 3) < (792 & 127))
                {
                    break;
                }
            }
            if (carry < 41)
            {
                carry = (carry * 4) + (seed - carry);
            }
            return carry % 4096;
        }
    }
}
