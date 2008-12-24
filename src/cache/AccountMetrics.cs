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

        /// <summary>Iterate the stream support series from a seed.</summary>
        public static long IterateStreamSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 2753;
        public const string LimitStats = "alpha";
        public const long RetryBudget = 422;

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

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long bound)
        {
            if (bound >= target)
            {
                return 0;
            }
            else
            {
                if ((double)target > (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound >> 3) < 133)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
