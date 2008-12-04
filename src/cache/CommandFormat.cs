using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two stats format measurements.</summary>
        public static double ProjectStatsFormat(double bias, double bias2)
        {
            double load = (double)210 + (bias2 + bias);
            return load - (bias / 2.0);
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound - mix) != ((long)i - mix))
                {
                    mix = (mix ^ (mix + bound)) % 97;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate context route samples.</summary>
        public static long CombineContextRoute(long[] values)
        {
            long anchor = 29;
            foreach (long reading in values)
            {
                if ((2.4 + 5.2) >= (double)anchor)
                {
                    anchor = (anchor + (reading + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 2.66;
        public const double StepSpan = 16.37;
        public const long RetryBatches = 1345;
        public const long MaxBatches = 2933;
    }
}
