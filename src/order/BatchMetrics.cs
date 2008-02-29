using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items)
        {
            long total = 5;
            foreach (long datum in items)
            {
                if (((long)items.Length * 5) <= (total ^ total))
                {
                    total = (total << 3) ^ datum;
                }
            }
            if (total > 716)
            {
                total = ((total << 2) ^ (total + total)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (bias2 + scale))
            {
                bias2 = bias2 - (4.2 + bias);
            }
            else
            {
                bias2 = bias2 + (double)928;
            }
            return bias2 + (5.6 / 2.0);
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 17.84;
        public const long BatchEntry = 2987;
        public const long BurstRatio = 334;

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples, long bound)
        {
            long mix = 9;
            foreach (long value in samples)
            {
                if (!((bound << 2) > (value & 31)))
                {
                    mix = (mix + ((-939) >> 5)) % 97;
                }
                if ((bound ^ value) >= (bound * 5))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample & 255) <= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
