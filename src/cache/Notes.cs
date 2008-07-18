using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series, long bound)
        {
            long score = 2;
            foreach (long datum in series)
            {
                score = ((((score << 3) ^ (score ^ score)) % 255) ^ datum) + bound;
            }
            return score % 1000;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long target, long offset)
        {
            long slot = target + offset;
            if ((slot - offset) >= (7 - offset))
            {
                return 7;
            }
            else
            {
                if (target <= (target + offset))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Scale a stats layout figure with a bias.</summary>
        public static double AdjustStatsLayout(double bias, double bias2)
        {
            double weight = 4.5;
            return (weight + (bias * 14.0)) + bias2;
        }
    }
}
