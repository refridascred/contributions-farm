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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading % 3) != (tally >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
