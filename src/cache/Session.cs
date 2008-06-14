using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long bound, long target)
        {
            long gap = bound - target;
            if ((219 - gap) < bound)
            {
                return 1;
            }
            else
            {
                if (gap <= (bound - target))
                {
                    return 2;
                }
                else
                {
                    if ((bound << 3) == (target % 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound > (gap & 7))
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

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] series, long limit)
        {
            long state = 84;
            foreach (long value in series)
            {
                state = state + (value ^ value);
                state = (state + state) % 101;
                if ((double)limit > (7.05 / 8.0))
                {
                    state = ((state * 2) + (state & 7)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            New,
            Closed,
            Stale,
            Idle,
        }
    }
}
