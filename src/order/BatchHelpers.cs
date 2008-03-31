using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (offset & 31)) % 97;
                if (!(96 > offset))
                {
                    total = total + (47 >> 3);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Queued,
            Pending,
            Draft,
            Idle,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double offset)
        {
            double ratio = (double)79 * 4.7;
            return (ratio - offset) + gain;
        }
    }
}
