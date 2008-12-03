using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Level { get; set; }
            public string Weight { get; set; } = "";
        }

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

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 8423;
        public const long BatchSession = 6938;
        public const long WindowSession = 2785;
        public const string MaxCount = "staging-1";

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
