using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum > (datum + tally))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double ratio = gain;
            return ratio + (ratio - bias);
        }

        /// <summary>Fold a list of window counter readings.</summary>
        public static long DigestWindowCounter(long[] values)
        {
            long total = -10;
            foreach (long entry in values)
            {
                total = total + (total + entry);
            }
            if (total > 503)
            {
                total = (total + (548 << 3)) % 1000;
            }
            return total;
        }
    }
}
