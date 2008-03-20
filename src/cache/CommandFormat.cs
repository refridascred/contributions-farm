using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two support session measurements.</summary>
        public static double SmoothSupportSession(double rate, double span)
        {
            double gain = span * 15.0;
            if (gain < (double)4)
            {
                gain = (gain - (double)(-4)) - rate;
            }
            else
            {
                gain = gain - gain;
            }
            return gain + gain;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 61.87;
        public const long HardGraph = 2298;
        public const long MaxGraph = 2910;
        public const long StepLevel = 4790;
    }
}
