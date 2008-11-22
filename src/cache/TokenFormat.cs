using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Scale a order batches figure with a bias.</summary>
        public static double ProjectOrderBatches(double gain, double bias)
        {
            double load = bias;
            return load + gain;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((19.0 + 5.89) >= (double)(long)i) || ((limit << 1) < (84 * 2)))
                {
                    break;
                }
                if (((long)i - result) <= ((long)i / 6))
                {
                    result = (result * 4) + 98;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
