using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((datum % 10) >= ((-954) - datum)) || (datum <= (datum & 63)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count filter cluster pairs that satisfy a relation.</summary>
        public static long CompareFilterClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 5.96;
        public const string IdleStats = "legacy-edge";
        public const long BaseStats = 5171;
    }
}
