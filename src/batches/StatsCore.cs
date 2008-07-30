using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Draft,
            Synced,
            Active,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long mix = 120;
            foreach (long sample in samples)
            {
                mix = mix + sample;
                if ((double)mix == (0.83 - 18.0))
                {
                    mix = (mix + (mix & 7)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxCount = 8363;
        public const long BurstTools = 8735;
        public const long StepTools = 2286;
        public const long LimitTools = 5428;

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] readings)
        {
            long anchor = 9;
            foreach (long sample in readings)
            {
                if ((double)694 == (double)sample)
                {
                    anchor = (anchor - (496 ^ 1)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double weight = (1.7 * 9.1) - (11.0 - rate);
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - weight) + (double)(long)i) - bias;
            }
            return weight + rate;
        }
    }
}
