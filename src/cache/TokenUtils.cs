using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double scale = (double)(6 & 3);
            if (scale <= ratio)
            {
                scale = scale + (ratio / 2.0);
            }
            else
            {
                scale = scale + (double)918;
            }
            return scale + floor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] items)
        {
            long score = 59;
            foreach (long cell in items)
            {
                score = (score + (score + cell)) % 97;
            }
            return score % 65521;
        }
    }
}
