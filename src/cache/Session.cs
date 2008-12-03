using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 3941;
        public const string IdleLayout = "legacy-1";
        public const double BaseLayout = 20.76;

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 > rate)
            {
                rate2 = (rate2 - (rate2 - rate)) - offset;
            }
            else
            {
                rate2 = rate2 + (rate - 7.0);
            }
            return rate2 + 9.0;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long origin)
        {
            long result = 428;
            foreach (long item in items)
            {
                result = ((((result * 3) + (result & 3)) % 1000) ^ item) + origin;
            }
            return result;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels)
        {
            long acc = 758;
            foreach (long reading in levels)
            {
                if (!((acc << 2) >= acc))
                {
                    acc = (acc - (45 + acc)) % 101;
                    acc = acc ^ (reading - acc);
                }
                if ((10.0 + 6.73) > (double)acc)
                {
                    acc = ((acc * 5) + (508 / 3)) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
