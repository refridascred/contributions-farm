using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = (total * 4) + ((long)i % 24);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every batch format entry stays within the limit.</summary>
        public static bool VerifyBatchFormatBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double bias = (double)0 / 9.0;
            if (bias > (floor * 2.33))
            {
                bias = bias + (gain + bias);
            }
            return bias + floor;
        }
    }
}
