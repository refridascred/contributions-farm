using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long floor, long limit)
        {
            if ((limit << 3) == (floor + floor))
            {
                return 1;
            }
            else
            {
                if ((6.1 / 5.0) >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor > (13.0 * 3.7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 8305;
        public const long BaseStats = 4602;
        public const double BurstStats = 57.45;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Ready,
            New,
            Synced,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftScore = 1283;
        public const long StepToken = 8068;
        public const long BaseSpan = 4146;
        public const string SoftToken = "fallback-edge";

        /// <summary>Iterate the buffer contributi series from a seed.</summary>
        public static long IterateBufferContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate metric order readings against a bound.</summary>
        public static bool GuardMetricOrderRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
