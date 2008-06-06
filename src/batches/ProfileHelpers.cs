using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((matches ^ (-273)) >= matches) && ((7.77 + 1.1) < (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 5350;
        public const double LimitWindow = 15.86;
        public const string BaseWidth = "local-v2";

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph cache samples.</summary>
        public static long FoldGraphCache(long[] items, long floor)
        {
            long carry = 139;
            foreach (long entry in items)
            {
                if ((entry << 1) > entry)
                {
                    carry = (carry << 2) ^ (floor + carry);
                }
                else
                {
                    carry = (carry + (carry ^ entry)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Idle,
            Retry,
            Failed,
            Active,
        }
    }
}
