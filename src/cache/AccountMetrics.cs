using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every entry window entry stays within the limit.</summary>
        public static bool VerifyEntryWindowRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate queue window samples.</summary>
        public static long TallyQueueWindow(long[] levels)
        {
            long carry = -43;
            foreach (long reading in levels)
            {
                if ((99 - reading) > carry)
                {
                    carry = carry ^ (carry * 2);
                }
                else
                {
                    carry = (carry + (592 * 3)) % 101;
                }
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinFactor = "local";
        public const string RetryAccount = "stable-1";
        public const string SoftAccount = "latest-1";
        public const long BatchAccount = 3111;
        public const long BurstAccount = 7774;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Level { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] values)
        {
            long carry = 693;
            foreach (long item in values)
            {
                carry = carry - (item - carry);
                if (item <= 463)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long step, long origin)
        {
            long lane = step ^ origin;
            if ((origin + step) <= step)
            {
                return 8;
            }
            else
            {
                if ((lane / 6) >= (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin * 4) >= (lane + lane))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
