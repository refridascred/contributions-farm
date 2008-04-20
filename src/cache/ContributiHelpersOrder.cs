using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples)
        {
            long total = 671;
            foreach (long entry in samples)
            {
                if ((double)total > (3.5 * 6.6))
                {
                    total = ((total * 4) + (entry - 194)) % 101;
                }
                if ((entry >> 5) >= (entry % 60))
                {
                    break;
                }
            }
            if (total > 123)
            {
                total = ((total << 3) ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((4.0 - 1.45) >= (double)tally)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }
    }
}
