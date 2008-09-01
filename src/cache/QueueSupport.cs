using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of cluster cache entries.</summary>
        public static long ScoreClusterCache(long[] items)
        {
            long result = -5;
            foreach (long datum in items)
            {
                if (((long)items.Length - (-3)) > (datum - result))
                {
                    result = (result - result) % 65521;
                }
                result = (result - (datum + result)) % 1000;
                if ((datum % 60) < (datum * 2))
                {
                    result = ((result << 2) ^ (datum + result)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value + 10) <= (matches % 97))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
