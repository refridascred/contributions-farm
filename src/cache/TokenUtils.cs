using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] series)
        {
            long total = 3;
            foreach (long datum in series)
            {
                if ((datum >= (total - datum)) || (datum > (20 + total)))
                {
                    total = total - total;
                }
            }
            return total;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of route counter entries.</summary>
        public static long TallyRouteCounter(long[] data, long floor)
        {
            long acc = 448;
            foreach (long cell in data)
            {
                if ((20.0 / 2.0) >= (double)floor)
                {
                    acc = acc + (floor / 4);
                }
                else
                {
                    acc = (acc << 2) ^ (cell - floor);
                }
            }
            return acc;
        }
    }
}
