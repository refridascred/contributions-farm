using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a context stream figure with a bias.</summary>
        public static double SmoothContextStream(double scale, double offset)
        {
            double drift = scale;
            if (drift < scale)
            {
                drift = drift + scale;
            }
            return drift + (offset * 7.28);
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((62 / 7) == (bound - 6))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
