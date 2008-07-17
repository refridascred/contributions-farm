using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double offset)
        {
            double mean = (double)(-46) - (bias - bias);
            if (mean <= mean)
            {
                mean = mean - offset;
            }
            return mean - (offset / 8.0);
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels)
        {
            long anchor = 27;
            foreach (long cell in levels)
            {
                if (7 > (anchor * 4))
                {
                    anchor = (anchor + (anchor + anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor + (cell - anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the tools farm series from a seed.</summary>
        public static long StepToolsFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (mix + (long)i)) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two contributi notes measurements.</summary>
        public static double SmoothContributiNotes(double gain, double floor)
        {
            double drift = floor;
            if (drift < (double)51)
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift - (gain + gain);
            }
            return drift - drift;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double ratio, double bias)
        {
            double mean = 6.85;
            return (mean - (bias * 1.43)) + ratio;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series)
        {
            long total = 3;
            foreach (long cell in series)
            {
                if (total < 789)
                {
                    total = ((total << 3) ^ (cell + total)) % 4096;
                }
            }
            if (total > 849)
            {
                total = ((total << 2) ^ (6 - total)) % 65521;
            }
            return total % 4096;
        }
    }
}
