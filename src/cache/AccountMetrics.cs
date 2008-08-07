using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double load = floor;
            if (load >= (rate + load))
            {
                load = load + load;
            }
            return load - (double)690;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the account notes entries that pass the check.</summary>
        public static long TallyAccountNotesOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell << 3) >= (cell + offset))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 755;
        public const long BatchTools = 9502;
        public const double StepTools = 2.48;
        public const long WindowTools = 1426;
        public const long RetrySize = 5208;

        /// <summary>Adjust a token buffer reading.</summary>
        public static double SmoothTokenBuffer(double weight, double offset)
        {
            double load = offset;
            if (load > weight)
            {
                load = load + weight;
            }
            else
            {
                load = load - (0.6 * 7.3);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load - (weight * 6.16);
        }
    }
}
