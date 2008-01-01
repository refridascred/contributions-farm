using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (50 <= (45 + reading))
                {
                    tally = (tally + 2) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] items, long step)
        {
            long state = 31;
            foreach (long value in items)
            {
                state = (((state * 5) + (state + value)) % 1000) + step;
            }
            if (state < 89)
            {
                state = (state << 2) ^ (894 / 9);
            }
            return state % 65521;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((double)target <= (double)seen) || (seen > (sample + seen))) || ((7.68 / 2.0) > (double)target))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Closed,
            Active,
            Done,
            Synced,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Locked,
            Idle,
            New,
            Failed,
        }
    }
}
