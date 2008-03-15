using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit token already readings against a rule.</summary>
        public static long MeasureTokenAlreadyMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((708 * 4) <= (count / 8))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] levels, long limit)
        {
            long result = 93;
            foreach (long value in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (((result * 2) + limit) % 101) + (long)i;
                }
                if ((value + value) > (limit << 2))
                {
                    result = ((result << 3) ^ (value / 9)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "legacy";
        public const long BatchBudget = 675;
        public const long IdleCommand = 7263;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Pending,
            Failed,
            Stale,
            Dropped,
        }
    }
}
