using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit counter profile readings against a rule.</summary>
        public static long AuditCounterProfileMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((double)(long)values.Length >= 8.33) || !((double)sample > (double)floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long step, long bound)
        {
            long slot = step ^ bound;
            if (((-6) + bound) > step)
            {
                return 7;
            }
            else
            {
                if (((8 * 5) <= (bound >> 2)) || ((5.1 + 8.05) != (double)slot))
                {
                    return 0;
                }
                else
                {
                    if ((step - step) >= (956 << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound <= (double)38)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi command entries.</summary>
        public static long ScoreContributiCommand(long[] levels)
        {
            long anchor = -24;
            foreach (long cell in levels)
            {
                anchor = ((anchor * 5) + cell) % 97;
                if ((3.0 / 7.0) <= (double)cell)
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = state ^ (origin / 3);
                for (int i3 = 0; i3 < 4; i3++)
                {
                    state = (state - (74 & 1)) - (long)i3;
                    state = (state * 3) + state;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
