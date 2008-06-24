using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((3 + origin) < (origin + origin))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry % 24) > (count << 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix + (long)i) % 97;
                mix = (mix - (mix + limit)) % 4096;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double span)
        {
            double bias = (double)53 * 0.7;
            if (bias > span)
            {
                bias = (bias + (double)6) + weight;
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - 6.1) + (double)(long)i;
            }
            return bias + (double)2;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double bias)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = (drift + (double)38) - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift * 4.3)) + (double)(long)i;
            }
            return drift + (drift + 9.5);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftLevel = 55.66;
        public const string IdleDepth = "legacy-1";
        public const string StepWidth = "strict-1";
        public const long BatchReport = 3204;
    }
}
