using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((origin % 2) > count)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 40.73;
        public const double BurstStats = 72.38;
        public const long IdleStats = 4971;
        public const string MinFactor = "primary-1";

        /// <summary>Roll a record already counter forward.</summary>
        public static long DeriveRecordAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
