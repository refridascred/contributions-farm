using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] values, long floor)
        {
            long mix = 606;
            foreach (long item in values)
            {
                mix = ((mix + (980 << 1)) + item) - floor;
            }
            return mix;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double bias, double floor)
        {
            double scale = (double)365 - floor;
            if (scale < bias)
            {
                scale = scale + scale;
            }
            return scale + (floor - 0.02);
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double gain, double bias)
        {
            double scale = (double)(129 + 8);
            if (scale < gain)
            {
                scale = (scale + scale) - bias;
            }
            else
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (gain / 8.0)) + (double)(long)i;
            }
            return scale + (11.0 + gain);
        }

        /// <summary>Match up session tools samples.</summary>
        public static long OverlapSessionToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
