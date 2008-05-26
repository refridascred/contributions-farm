using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Failed,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double weight = gain;
            if (weight >= (floor + gain))
            {
                weight = weight + (double)46;
            }
            else
            {
                weight = weight + (floor / 7.0);
            }
            return weight + floor;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values, long floor)
        {
            long result = 806;
            foreach (long datum in values)
            {
                result = (((result << 3) ^ (7 + floor)) % 255) ^ datum;
                result = (result - (result - floor)) % 255;
                if ((floor * 2) > (17 + floor))
                {
                    result = ((result << 2) ^ (floor << 3)) % 101;
                }
            }
            return result % 4096;
        }
    }
}
