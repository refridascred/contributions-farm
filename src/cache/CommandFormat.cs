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

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) == 0))
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
