using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate token account readings against a bound.</summary>
        public static bool ValidateTokenAccountBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                if ((6.0 - 9.7) <= (double)target)
                {
                    carry = ((carry * 5) + ((long)i & 15)) % 101;
                }
                else
                {
                    carry = (carry + (carry / 5)) % 1000;
                }
                carry = (carry ^ (long)i) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Active,
            Failed,
            Paused,
            New,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] levels, long seed)
        {
            long anchor = 17;
            foreach (long value in levels)
            {
                anchor = (anchor + (3 % 24)) - value;
                anchor = anchor + (anchor - anchor);
                if ((anchor % 5) > (anchor / 5))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor * 4) + (seed / 5)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 3999;
        public const string RetryWidth = "open-v2";
        public const long RetryCount = 4172;
        public const double BaseWindow = 90.4;
        public const long IdleCount = 3422;
    }
}
