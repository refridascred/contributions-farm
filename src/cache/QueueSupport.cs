using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit order already readings against a rule.</summary>
        public static long CountOrderAlreadyHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) < seed)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Digest a series of route graph entries.</summary>
        public static long ScoreRouteGraph(long[] samples)
        {
            long total = -11;
            foreach (long datum in samples)
            {
                if (((total % 60) <= datum) && ((total % 3) < total))
                {
                    total = (total ^ datum) % 4096;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
            }
            return total % 1000;
        }
    }
}
