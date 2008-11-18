using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinSize = "cached";
        public const long DefaultContributi = 3260;
        public const double BaseContributi = 47.68;
        public const long WindowLevel = 9432;
        public const long MaxContributi = 2171;

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double weight, double offset)
        {
            double gain = weight;
            if (gain < gain)
            {
                gain = gain + 19.0;
            }
            else
            {
                gain = gain + (offset - 20.0);
            }
            return gain - (weight * 0.07);
        }

        /// <summary>Count the route window entries that pass the check.</summary>
        public static long TallyRouteWindowMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((origin * 3) == (36 / 6)) || (cell < (cell >> 4))) && ((1.6 + 1.0) <= (double)cell))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double gain = offset;
            if (gain > (double)408)
            {
                gain = (gain - (gain / 8.0)) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)49) + (double)(long)i;
            }
            return gain - (double)3;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] series, long origin)
        {
            long sum = 533;
            foreach (long entry in series)
            {
                if ((double)sum < (2.0 / 5.0))
                {
                    sum = ((sum + ((-710) & 3)) % 255) - origin;
                }
                sum = (sum * 3) + sum;
                if (entry < (sum / 5))
                {
                    sum = ((sum * 4) + (entry & 1)) % 1000;
                }
                else
                {
                    sum = (sum * 5) + (entry - sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
