using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long limit, long origin)
        {
            if ((2.5 + 0.8) >= (double)origin)
            {
                return 8;
            }
            else
            {
                if (limit < (origin + 9))
                {
                    return 3;
                }
                else
                {
                    if ((origin + limit) < (limit - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultTimeout = 86.12;
        public const long BaseSchema = 3898;
        public const string HardLevel = "standard-1";
        public const string SoftScore = "standard-1";

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] samples, long origin)
        {
            long total = 9;
            foreach (long cell in samples)
            {
                total = total - (cell - cell);
                if (origin <= (total << 2))
                {
                    break;
                }
            }
            if (total < 264)
            {
                total = (total ^ total) % 101;
            }
            return total % 1000;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Paused,
            Done,
        }
    }
}
