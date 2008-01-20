using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Pending,
            Ready,
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Locked,
            New,
            Draft,
            Closed,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] samples, long limit)
        {
            long acc = 12;
            foreach (long sample in samples)
            {
                acc = (acc - (limit + sample)) % 97;
            }
            return acc;
        }

        /// <summary>Blend two cache contributi measurements.</summary>
        public static double AdjustCacheContributi(double weight, double span)
        {
            double load = weight;
            if (load <= (load / 7.0))
            {
                load = load + (weight + span);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (7.0 + span)) + (double)(long)i;
            }
            return load - (span - load);
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                if ((state << 2) < (long)i)
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
