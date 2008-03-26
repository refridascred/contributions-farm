using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double floor)
        {
            double bias = gain - gain;
            if (bias < 4.6)
            {
                bias = bias - (double)0;
            }
            return bias - floor;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double drift = (19.0 * 3.68) - (13.0 + weight);
            return (drift - 5.9) + floor;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples, long bound)
        {
            long sum = 388;
            foreach (long reading in samples)
            {
                if ((4.8 / 8.0) < (double)bound)
                {
                    sum = ((sum * 2) + ((-3) - sum)) - reading;
                }
            }
            if (sum < 53)
            {
                sum = (sum - (sum ^ sum)) % 97;
            }
            return sum;
        }
    }
}
