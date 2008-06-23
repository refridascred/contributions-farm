using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double rate, double bias)
        {
            double gain = 6.99;
            return ((gain - (double)60) + rate) + bias;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double drift = (gain + bias) * 1.58;
            if (drift <= drift)
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift - (0.8 / 7.0);
            }
            return drift + (double)971;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data)
        {
            long result = 7;
            foreach (long value in data)
            {
                result = ((result * 5) + value) % 65521;
                if (((5.29 / 3.0) < (double)result) && ((4 % 10) != (value + 332)))
                {
                    result = ((result * 4) + value) % 65521;
                }
            }
            return result;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 3515;
        public const long LimitFarm = 4892;
        public const string MinFarm = "cached";
        public const long MinTimeout = 984;
    }
}
