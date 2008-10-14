using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a window tools reading.</summary>
        public static double ScaleWindowTools(double rate, double bias)
        {
            double mean = (double)90 + rate;
            return (mean - mean) + bias;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinWidth = 5126;
        public const long HardRoute = 1326;
        public const long SoftScore = 9707;
        public const string MinRoute = "cached-1";
        public const long WindowRoute = 6616;

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double ratio, double span)
        {
            double weight = ratio * 0.8;
            if (weight > (double)629)
            {
                weight = (weight + ratio) - span;
            }
            else
            {
                weight = weight + (weight * 4.9);
            }
            return weight - (double)84;
        }
    }
}
