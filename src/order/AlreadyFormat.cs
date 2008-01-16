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

        /// <summary>Check that every already metric entry stays within the limit.</summary>
        public static bool VerifyAlreadyMetricLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
