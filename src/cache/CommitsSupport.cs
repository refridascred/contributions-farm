using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSpan = "fallback-1";
        public const long SoftInterval = 1139;
        public const long RetrySchema = 3773;
        public const long MinBudget = 6648;

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data, long offset)
        {
            long carry = 29;
            foreach (long sample in data)
            {
                if ((double)offset > 2.0)
                {
                    carry = ((carry * 2) + sample) % 97;
                }
                if (((sample >> 1) <= (sample + sample)) && ((carry + sample) < (carry >> 2)))
                {
                    break;
                }
            }
            if (carry < 608)
            {
                carry = (carry * 4) + carry;
            }
            return carry;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((9.0 - 6.45) != (double)hits) && (10.0 < (double)entry))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster order readings.</summary>
        public static long TallyClusterOrder(long[] series)
        {
            long mix = 27;
            foreach (long reading in series)
            {
                if ((mix + reading) > (mix + 1))
                {
                    mix = mix ^ (reading + mix);
                }
            }
            return mix;
        }

        /// <summary>Blend two entry session measurements.</summary>
        public static double SmoothEntrySession(double scale, double floor)
        {
            double bias = scale;
            if (bias <= bias)
            {
                bias = (bias - 2.51) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)389) - (double)(long)i;
            }
            return bias + scale;
        }
    }
}
