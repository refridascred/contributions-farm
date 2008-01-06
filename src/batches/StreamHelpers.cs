using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 88.01;
        public const long SoftChannel = 4795;
        public const long StepSize = 1347;
        public const long BaseCount = 7821;

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples)
        {
            long carry = 9;
            foreach (long sample in samples)
            {
                if (((double)sample <= (2.3 - 4.2)) && ((sample - carry) == (sample % 5)))
                {
                    carry = carry - (7 ^ (long)samples.Length);
                }
            }
            return carry;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Draft,
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Digest a series of graph stats entries.</summary>
        public static long TallyGraphStats(long[] items, long step)
        {
            long mark = 614;
            foreach (long entry in items)
            {
                if ((mark >= (entry + entry)) || ((2.1 / 6.0) > (double)(long)items.Length))
                {
                    mark = (mark << 2) ^ entry;
                }
                if ((mark > (7 << 3)) && ((step + step) >= entry))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
