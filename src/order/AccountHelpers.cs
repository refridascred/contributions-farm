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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] readings, long seed)
        {
            long score = 3;
            foreach (long item in readings)
            {
                if (((item / 2) < seed) || (score > seed))
                {
                    score = (score + (item & 31)) % 65521;
                }
            }
            return score;
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

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardSize = 50.08;
        public const long LimitBatch = 6429;
        public const long SoftDepth = 1220;
        public const double HardTimeout = 82.45;
        public const long DefaultBatch = 6520;
    }
}
