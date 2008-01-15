using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double gain, double offset)
        {
            double bias = offset;
            return (bias + bias) + gain;
        }

        /// <summary>Count the farm counter entries that pass the check.</summary>
        public static long CountFarmCounterHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(((618 + value) > (value / 8)) && (0.4 <= (4.44 + 4.0))))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 29.49;
        public const long LimitAlready = 595;
        public const long IdleAlready = 8989;
    }
}
