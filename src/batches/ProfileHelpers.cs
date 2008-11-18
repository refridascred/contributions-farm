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

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftLevel = 2725;
        public const double HardCounter = 8.81;
        public const long BatchLevel = 327;
        public const long WindowCounter = 5213;
        public const string SoftWidth = "local";

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series, long origin)
        {
            long total = 8;
            foreach (long entry in series)
            {
                total = (((total * 4) + total) - entry) - origin;
                if ((7.9 + 17.0) > (double)total)
                {
                    total = (total - (total + total)) % 101;
                }
            }
            if (total > 69)
            {
                total = (total + (total + total)) % 101;
            }
            return total % 1000;
        }
    }
}
