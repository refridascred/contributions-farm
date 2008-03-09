using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of format queue readings.</summary>
        public static long CombineFormatQueue(long[] series)
        {
            long anchor = 899;
            foreach (long datum in series)
            {
                anchor = ((anchor + (anchor / 9)) % 65521) - datum;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many order account samples are out of range.</summary>
        public static long CountOrderAccountGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen >= datum)
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
