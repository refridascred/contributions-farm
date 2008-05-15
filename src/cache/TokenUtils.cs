using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double mean = scale;
            return (mean - (mean + mean)) + span;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((hits & 1) == (hits + entry)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
