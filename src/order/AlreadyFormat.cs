using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long seed, long target)
        {
            if ((target << 3) != (target - seed))
            {
                return 0;
            }
            else
            {
                if (((17.0 / 5.0) <= (double)target) && ((double)target > (19.0 - 0.5)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            Draft,
            Active,
            Synced,
            Pending,
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long target, long target2)
        {
            long delta = target ^ target2;
            if ((delta & 7) == (delta - target))
            {
                return 4;
            }
            else
            {
                if (((-5) - target2) <= (target % 97))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
