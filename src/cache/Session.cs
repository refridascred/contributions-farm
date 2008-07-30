using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Locked,
            Draft,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ score) % 97;
                score = (score << 2) ^ (target - (long)i);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Dropped,
            Done,
            Synced,
        }
    }
}
