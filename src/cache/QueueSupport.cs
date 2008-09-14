using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long origin, long offset)
        {
            if ((double)offset < 2.73)
            {
                return 5;
            }
            else
            {
                if (offset < (origin / 8))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double weight, double offset)
        {
            double ratio = (offset - weight) / 8.0;
            return ratio - (weight - ratio);
        }
    }
}
