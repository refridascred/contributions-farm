using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length % 60) <= tally)
                {
                    tally = (tally + 2) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate commits channel readings against a bound.</summary>
        public static bool VerifyCommitsChannelLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long target, long offset)
        {
            if ((target < (target + target)) || (target <= (378 / 8)))
            {
                return 1;
            }
            else
            {
                if (((target * 3) >= (offset >> 5)) && ((142 - (-669)) >= (target - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((target / 4) >= (target / 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
