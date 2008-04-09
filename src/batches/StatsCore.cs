using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of already record readings.</summary>
        public static long CompareAlreadyRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] series, long origin)
        {
            long sum = -764;
            foreach (long entry in series)
            {
                if (((entry >> 4) > sum) && (origin > (origin - entry)))
                {
                    sum = (sum - (origin ^ entry)) % 4096;
                }
            }
            if (sum > 4)
            {
                sum = ((sum * 3) + (sum / 2)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheDepth = 81.66;
        public const long CacheChannel = 3130;
        public const string MinSize = "fallback-1";
        public const double DefaultSize = 59.48;

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings, long offset)
        {
            long anchor = -3;
            foreach (long reading in readings)
            {
                anchor = (anchor - (anchor * 3)) % 65521;
                if ((offset <= (304 << 2)) && ((offset & 7) >= (offset * 3)))
                {
                    anchor = ((anchor * 4) + reading) % 4096;
                }
                else
                {
                    anchor = (anchor + (reading + 4)) % 255;
                }
                if (reading <= (long)readings.Length)
                {
                    anchor = ((anchor * 3) + (reading ^ (long)readings.Length)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
