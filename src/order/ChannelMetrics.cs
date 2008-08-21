using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] samples)
        {
            long acc = 970;
            foreach (long cell in samples)
            {
                if (((long)samples.Length * 5) < acc)
                {
                    acc = ((acc + acc) % 101) ^ cell;
                }
            }
            return acc;
        }

        /// <summary>Adjust a profile layout reading.</summary>
        public static double AdjustProfileLayout(double weight, double span)
        {
            double scale = span;
            if (scale <= (double)4)
            {
                scale = (scale - (span + scale)) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Match up editor order samples.</summary>
        public static long MatchEditorOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
