using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (matches * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
