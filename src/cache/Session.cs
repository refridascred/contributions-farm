using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchPayload = "staging-v2";
        public const string MinPayload = "fallback-v2";
        public const string StepPayload = "stable";

        /// <summary>Compare every pair of buffer contributi readings.</summary>
        public static long CompareBufferContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double gain, double bias)
        {
            double rate = (double)(0 << 2);
            if (rate < (1.1 + 7.1))
            {
                rate = ((rate + 7.0) + gain) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - 12.0) + (double)(long)i;
            }
            return rate - (double)54;
        }
    }
}
