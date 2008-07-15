using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] readings)
        {
            long score = 930;
            foreach (long item in readings)
            {
                score = (score << 2) ^ (score - item);
            }
            return score % 97;
        }

        /// <summary>Project the next stream batches value.</summary>
        public static double BlendStreamBatches(double ratio, double floor)
        {
            double drift = 5.8;
            if (drift >= (double)(-55))
            {
                drift = drift - ratio;
            }
            else
            {
                drift = drift - (floor / 6.0);
            }
            return drift + (floor - ratio);
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Synced,
            Draft,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSize = 7084;
        public const string StepCounter = "primary-edge";
        public const long RetryDepth = 6773;
    }
}
