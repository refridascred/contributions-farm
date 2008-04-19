using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultLevel = 6235;
        public const double IdleBatches = 67.3;
        public const string BatchBatches = "cached";
        public const long DefaultScore = 2544;

        /// <summary>Adjust a stream commits reading.</summary>
        public static double ProjectStreamCommits(double scale, double span)
        {
            double weight = span;
            if (weight >= 9.2)
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (weight / 6.0)) + (double)(long)i;
            }
            return weight + (scale * 9.2);
        }

        /// <summary>Combine cache order values into a single score.</summary>
        public static long TotalCacheOrder(long[] series, long origin)
        {
            long mix = 583;
            foreach (long value in series)
            {
                mix = (mix + origin) % 97;
                mix = (mix ^ value) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
