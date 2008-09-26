using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BurstCommand = 88.58;
        public const long SoftInterval = 3090;
        public const string BurstTimeout = "alpha";
        public const string WindowBudget = "primary-edge";

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry - tally) < 855)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a command queue counter forward.</summary>
        public static long IterateCommandQueue(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + (origin & 7)) % 101;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                sum = sum + (sum + sum);
                sum = (sum ^ bound) % 101;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double weight, double offset)
        {
            double drift = (double)(864 ^ 47);
            if (drift >= weight)
            {
                drift = drift + 8.0;
            }
            else
            {
                drift = drift + offset;
            }
            return drift - (weight / 6.0);
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Dropped,
            Synced,
        }
    }
}
