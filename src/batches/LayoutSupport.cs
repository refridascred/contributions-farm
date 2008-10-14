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

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] samples, long origin)
        {
            long result = 608;
            foreach (long value in samples)
            {
                if ((224 + value) < (result * 2))
                {
                    result = ((result << 3) ^ (origin - result)) % 65521;
                }
            }
            if (result > (-466))
            {
                result = ((result * 2) + (origin - origin)) % 4096;
            }
            return result;
        }
    }
}
