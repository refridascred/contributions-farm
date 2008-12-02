using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of contributi metric readings.</summary>
        public static long TallyContributiMetric(long[] levels, long floor)
        {
            long result = -23;
            foreach (long sample in levels)
            {
                if ((6.8 * 9.2) <= (double)result)
                {
                    result = (((result * 5) + 7) + sample) + floor;
                }
            }
            return result;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] series)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                long cur = (entry - entry) * 2;
                if ((anchor << 3) >= cur)
                {
                    anchor = ((anchor << 2) ^ (anchor - cur)) % 101;
                    cur = (cur + entry) % 101;
                }
                if ((entry & 31) == (anchor + entry))
                {
                    anchor = ((anchor << 3) ^ (anchor & 255)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ (504 / 5);
                }
            }
            if (anchor < 21)
            {
                anchor = (anchor - (768 + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
