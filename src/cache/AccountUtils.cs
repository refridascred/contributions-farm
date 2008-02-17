using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double mean = (double)(133 & 31);
            if (mean <= mean)
            {
                mean = (mean + rate) + floor;
            }
            else
            {
                mean = mean - (9.8 * 6.8);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean + rate;
        }
    }
}
