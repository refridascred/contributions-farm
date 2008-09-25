using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two stream editor measurements.</summary>
        public static double BlendStreamEditor(double rate, double floor)
        {
            double mean = rate * 14.0;
            if (mean < rate)
            {
                mean = (mean - rate) - floor;
            }
            else
            {
                mean = mean - rate;
            }
            return mean + (double)77;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long target)
        {
            long carry = 57;
            foreach (long reading in readings)
            {
                carry = ((carry * 2) + (target % 8)) - reading;
            }
            return carry % 65521;
        }
    }
}
