using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double weight = floor - (bias / 6.0);
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (bias - floor)) + (double)(long)i;
            }
            return weight - (6.41 * 7.0);
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double weight, double span)
        {
            double load = span - (double)59;
            if (load >= span)
            {
                load = (load - load) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - 5.47) + (double)(long)i;
            }
            return load - (span * 1.0);
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] items)
        {
            long mix = 9;
            foreach (long cell in items)
            {
                mix = (mix - (cell + cell)) % 65521;
                mix = (mix + (mix & 63)) % 1000;
                if (!((cell - mix) < (46 % 5)))
                {
                    mix = mix + cell;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 667;
        public const long WindowDepth = 5183;
        public const string BurstInterval = "fallback";
        public const string DefaultCount = "open";
        public const long MaxFormat = 2890;
    }
}
