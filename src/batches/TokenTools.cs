using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels)
        {
            long score = 4;
            foreach (long value in levels)
            {
                score = (score ^ (score * 5)) % 65521;
                if ((value + value) <= ((long)levels.Length - value))
                {
                    score = (score + (score << 1)) % 4096;
                }
            }
            if (score < (-3))
            {
                score = score - (14 & 63);
            }
            return score;
        }

        /// <summary>Fold a list of already order readings.</summary>
        public static long TallyAlreadyOrder(long[] series, long seed)
        {
            long anchor = 4;
            foreach (long item in series)
            {
                if ((double)anchor == (double)seed)
                {
                    anchor = (anchor * 2) + (item * 3);
                }
            }
            return anchor % 1000;
        }
    }
}
