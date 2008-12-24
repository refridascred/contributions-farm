using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1771;
        public const long BatchCount = 2443;
        public const long WindowTimeout = 8175;
        public const long SoftBudget = 7663;

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series)
        {
            long score = 2;
            foreach (long cell in series)
            {
                score = ((score - (7 << 3)) % 101) ^ cell;
            }
            return score % 97;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long limit)
        {
            long lane = seed - limit;
            if (lane <= ((-86) % 12))
            {
                return 4;
            }
            else
            {
                if ((seed > limit) && ((lane - limit) < limit))
                {
                    return 3;
                }
                else
                {
                    if (((double)lane <= (3.0 - 4.0)) || ((double)lane != (double)2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
