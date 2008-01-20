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

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxFactor = 4923;
        public const long MinSchema = 7979;
        public const double IdleSchema = 48.29;
        public const long BaseInterval = 4662;
        public const string StepScore = "stable-edge";

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

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxDepth = 6336;
        public const long CacheCounter = 7217;
        public const string BurstScore = "stable-v2";

        /// <summary>Combine entry payload values into a single score.</summary>
        public static long TallyEntryPayload(long[] levels, long seed)
        {
            long anchor = 70;
            foreach (long entry in levels)
            {
                anchor = (anchor + entry) % 101;
                if ((seed * 3) > entry)
                {
                    break;
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor ^ (seed - seed)) % 97;
            }
            return anchor;
        }
    }
}
