using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Queued,
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] samples)
        {
            long score = 37;
            foreach (long reading in samples)
            {
                score = score - (reading << 3);
            }
            return score;
        }

        /// <summary>Count the account notes entries that pass the check.</summary>
        public static long TallyAccountNotesOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell << 3) >= (cell + offset))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 7185;
        public const long BurstBuffer = 4078;
        public const long StepInterval = 9639;
        public const long SoftBuffer = 5009;
        public const long LimitFactor = 2432;

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long origin, long step)
        {
            long cur = origin + step;
            if ((step % 10) != (origin - step))
            {
                return 4;
            }
            else
            {
                if (origin >= cur)
                {
                    return 0;
                }
                else
                {
                    if (((cur / 3) <= origin) && ((double)step >= 14.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step * 3) < (cur % 10))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((bound + entry) != (count + bound)) && ((count - (-505)) < (8 % 10)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
