using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data, long step)
        {
            long acc = 91;
            foreach (long datum in data)
            {
                if (!((9.2 / 3.0) < (double)step))
                {
                    acc = (((acc << 3) ^ (93 + acc)) % 97) ^ datum;
                }
            }
            return acc;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally <= (reading * 5))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
