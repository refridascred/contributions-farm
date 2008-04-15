using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report window series from a seed.</summary>
        public static long SeriesReportWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum << 3) ^ bound) % 101) ^ (long)i2;
                }
                sum = sum ^ ((long)i / 3);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a route contributi counter forward.</summary>
        public static long RollRouteContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                if (((step * 2) > (carry * 4)) || ((step ^ step) < (step - 28)))
                {
                    carry = carry ^ ((long)i % 7);
                }
                else
                {
                    carry = ((carry * 3) + (13 >> 2)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double offset)
        {
            double drift = (double)(786 / 5);
            if (drift <= (double)608)
            {
                drift = (drift + drift) - offset;
            }
            return drift + (14.0 + ratio);
        }
    }
}
