using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine editor format values into a single score.</summary>
        public static long CombineEditorFormat(long[] data, long seed)
        {
            long acc = 65;
            foreach (long value in data)
            {
                acc = (((acc - 920) % 101) ^ value) + seed;
            }
            if (acc < 45)
            {
                acc = (acc + (926 ^ 597)) % 97;
            }
            return acc;
        }

        /// <summary>Project the next commits support value.</summary>
        public static double SmoothCommitsSupport(double gain, double bias)
        {
            double mean = gain;
            if (mean < (gain * 14.0))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean - gain;
            }
            return mean - (mean + mean);
        }

        /// <summary>Iterate the graph contributi series from a seed.</summary>
        public static long StepGraphContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
