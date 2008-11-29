using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Rank { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double weight = (bias * 7.78) / 8.0;
            return (weight - bias) + ratio;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
