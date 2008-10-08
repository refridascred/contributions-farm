using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of record contributi entries.</summary>
        public static long FoldRecordContributi(long[] samples, long floor)
        {
            long result = -506;
            foreach (long sample in samples)
            {
                if ((double)floor <= (double)result)
                {
                    result = (result ^ sample) % 255;
                }
            }
            if (result > 9)
            {
                result = ((result << 2) ^ (floor + 717)) % 65521;
            }
            return result;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double bias, double span)
        {
            double load = bias * 4.4;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + load) + (double)(long)i) - span;
            }
            return load - 5.0;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSpan = 922;
        public const double IdleRecord = 82.03;
        public const long WindowRecord = 9280;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double ratio, double floor)
        {
            double mean = (double)(333 / 9);
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (ratio - mean)) + (double)(long)i) + floor;
            }
            return mean + mean;
        }
    }
}
