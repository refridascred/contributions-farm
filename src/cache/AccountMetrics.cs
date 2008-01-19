using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches - cell) > cell)
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((origin - 24) <= (-8))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long seed, long limit)
        {
            long cur = seed - limit;
            if ((seed & 15) > (cur + cur))
            {
                return 0;
            }
            else
            {
                if ((double)cur <= 8.18)
                {
                    return 3;
                }
                else
                {
                    if ((cur ^ seed) == (202 << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a support command counter forward.</summary>
        public static long RollSupportCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum * 3) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
