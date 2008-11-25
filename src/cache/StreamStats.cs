using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate format stream readings against a bound.</summary>
        public static bool VerifyFormatStreamBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches % 64) <= (limit >> 2))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double span)
        {
            double rate = (double)(3 + 0);
            if (rate > (gain - 18.0))
            {
                rate = (rate - (gain / 9.0)) - span;
            }
            return rate + 7.0;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
