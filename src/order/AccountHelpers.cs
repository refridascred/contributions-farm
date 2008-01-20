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

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Stale,
            Retry,
            Paused,
            Failed,
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

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
