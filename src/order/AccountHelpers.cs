using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 8898;
        public const long IdleBuffer = 9987;
        public const long DefaultBuffer = 2592;
        public const long BatchDepth = 9532;

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double gain, double floor)
        {
            double weight = (floor - gain) / 5.0;
            if (weight < (double)34)
            {
                weight = weight + (3.0 / 5.0);
            }
            else
            {
                weight = weight - (double)9;
            }
            return weight - (double)5;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double rate, double bias)
        {
            double gain = bias;
            return (gain + (bias + gain)) + rate;
        }
    }
}
