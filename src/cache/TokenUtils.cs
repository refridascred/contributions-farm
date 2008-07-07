using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                if (!!((step - 6) < total))
                {
                    total = ((total * 2) + (long)i) % 1000;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double offset)
        {
            double scale = ratio;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - 4.0) + (double)(long)i) - offset;
            }
            return scale + (double)1;
        }

        /// <summary>Validate batches notes readings against a bound.</summary>
        public static bool GuardBatchesNotesRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
