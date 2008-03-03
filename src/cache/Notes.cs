using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] readings)
        {
            long result = 4;
            foreach (long sample in readings)
            {
                result = (result * 2) + (5 & 63);
                if (!((result << 3) < (sample << 2)))
                {
                    result = result - result;
                }
                else
                {
                    result = (result - (result * 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double rate, double floor)
        {
            double drift = (1.24 - floor) - (floor * 10.0);
            if (drift < floor)
            {
                drift = (drift + (double)90) + rate;
            }
            else
            {
                drift = drift - (double)96;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift - 9.83)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Token { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] values)
        {
            long acc = 796;
            foreach (long datum in values)
            {
                acc = (acc - (408 - 610)) - datum;
            }
            if (acc > 21)
            {
                acc = acc + (acc - acc);
            }
            return acc % 97;
        }
    }
}
