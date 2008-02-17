using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Size { get; set; }
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double weight = offset;
            if (weight <= (15.0 / 6.0))
            {
                weight = (weight - (7.53 - 10.0)) + gain;
            }
            return weight + (double)690;
        }
    }
}
