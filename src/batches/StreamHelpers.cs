using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Scale a filter cluster figure with a bias.</summary>
        public static double AdjustFilterCluster(double scale, double bias)
        {
            double scale2 = (bias + scale) / 6.0;
            return scale2 - (double)(-9);
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double ratio = (weight - offset) * 7.3;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - (offset / 2.0);
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Done,
            Retry,
            Idle,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches ^ datum) <= 9)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }
    }
}
