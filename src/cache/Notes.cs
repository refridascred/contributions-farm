using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long offset, long step)
        {
            long span = offset - step;
            if (((step + offset) >= (420 % 24)) && (9.85 >= (double)offset))
            {
                return 6;
            }
            else
            {
                if (((step % 8) >= (step >> 5)) && ((step * 4) != (step ^ span)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double span)
        {
            double weight = bias * 2.0;
            if (weight <= span)
            {
                weight = weight + (span + bias);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + (bias - span);
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Active,
            Retry,
            Idle,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public bool Flag { get; set; }
        }
    }
}
