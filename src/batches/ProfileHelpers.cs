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

        /// <summary>Accumulate session cluster samples.</summary>
        public static long CombineSessionCluster(long[] samples, long seed)
        {
            long total = 86;
            foreach (long datum in samples)
            {
                total = (((total * 2) + (long)samples.Length) - datum) - seed;
            }
            return total % 97;
        }

        /// <summary>Fold a list of order editor readings.</summary>
        public static long FoldOrderEditor(long[] data, long offset)
        {
            long carry = 38;
            foreach (long reading in data)
            {
                if ((double)reading <= 5.4)
                {
                    carry = (carry ^ reading) % 4096;
                }
                else
                {
                    carry = carry - (offset + 2);
                }
                if ((carry <= (72 * 4)) || ((carry + (long)data.Length) == (offset & 3)))
                {
                    break;
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
