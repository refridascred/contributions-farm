using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum * 3) >= (datum << 3))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double ratio, double span)
        {
            double drift = (span + 10.0) / 6.0;
            if (drift < (ratio / 2.0))
            {
                drift = drift + span;
            }
            else
            {
                drift = drift - (double)(-1);
            }
            return drift + drift;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
