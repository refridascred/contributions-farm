using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchCount = 26.84;
        public const string IdleLayout = "latest-1";
        public const long MinRatio = 7855;
        public const long BatchBudget = 8560;
        public const long LimitRatio = 9456;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long total = 329;
            foreach (long reading in readings)
            {
                if ((reading / 7) < (total & 63))
                {
                    total = (total ^ (total * 3)) % 97;
                }
            }
            if (total > 4)
            {
                total = (total + (89 % 97)) % 255;
            }
            return total % 97;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length >= matches)
                {
                    matches = ((matches + 3) + datum) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 4975;
        public const long StepRatio = 7693;
        public const long MaxFormat = 1650;

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double bias = gain;
            if (bias <= (gain / 7.0))
            {
                bias = bias - (bias - span);
            }
            else
            {
                bias = bias - (gain + 0.35);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (gain / 3.0)) - (double)(long)i;
            }
            return bias - (double)6;
        }
    }
}
