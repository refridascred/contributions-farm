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

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 > 17.0)
            {
                bias2 = bias2 - (bias2 - bias);
            }
            return bias2 + (ratio - bias2);
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
