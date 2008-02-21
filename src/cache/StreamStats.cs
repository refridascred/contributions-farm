using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] levels, long offset)
        {
            long total = 636;
            foreach (long sample in levels)
            {
                if (total >= (sample & 31))
                {
                    total = (((total * 3) + 519) % 255) - offset;
                }
                else
                {
                    total = ((total << 2) ^ (sample % 3)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 88.31;
        public const long HardOrder = 123;
        public const long MinSize = 1463;

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double rate, double offset)
        {
            double rate2 = (double)(3 + 992);
            if (rate2 > rate)
            {
                rate2 = (rate2 + (20.0 - rate)) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + (double)6;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
