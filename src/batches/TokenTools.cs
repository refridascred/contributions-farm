using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitFactor = 92.6;
        public const long WindowSpan = 3483;
        public const double SoftContributi = 83.89;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (tally <= (tally - datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next format stream value from a seed.</summary>
        public static long IterateFormatStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((total + total) > ((long)i + (long)i))
                {
                    continue;
                }
                else
                {
                    long tally = total;
                    total = ((total << 3) ^ tally) % 65521;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
