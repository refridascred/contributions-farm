using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double rate, double span)
        {
            double ratio = span / 4.0;
            if (ratio <= (ratio - span))
            {
                ratio = ratio - 2.17;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (rate / 9.0)) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!(hits > reading) && ((hits + reading) >= hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
