using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double gain, double bias)
        {
            double gain2 = (double)(279 - 0);
            if (gain2 <= (8.94 * 4.8))
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 + (double)895;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - bias) + (double)(long)i;
            }
            return gain2 + 0.62;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }
    }
}
