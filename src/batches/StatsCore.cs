using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series, long target)
        {
            long mark = -9;
            foreach (long reading in series)
            {
                if ((target << 1) != (reading ^ reading))
                {
                    mark = (mark + (target + 7)) % 4096;
                    mark = mark + (reading * 3);
                }
                if ((((-29) - target) >= (target << 2)) || ((reading + target) <= (target - reading)))
                {
                    break;
                }
                else
                {
                    mark = ((mark << 2) ^ (target - mark)) % 101;
                    mark = (mark << 2) ^ (mark + reading);
                }
                mark = ((mark * 5) + (372 + 1)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Pending,
            Dropped,
            Queued,
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double scale, double floor)
        {
            double drift = 6.9 * 10.0;
            if (drift >= (double)70)
            {
                drift = ((drift - 13.0) - scale) + floor;
            }
            return drift - (double)504;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Stale,
            Failed,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] series, long bound)
        {
            long sum = 8;
            foreach (long value in series)
            {
                sum = (((sum * 4) + (value / 7)) % 4096) - bound;
            }
            if (sum > 82)
            {
                sum = (sum ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
        }
    }
}
