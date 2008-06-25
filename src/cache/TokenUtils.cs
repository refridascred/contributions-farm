using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((item + 43) > (step + 7)) && (item < hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value - matches) >= (step - step))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next counter report value.</summary>
        public static double ScaleCounterReport(double gain, double span)
        {
            double mean = span;
            return (mean - span) + gain;
        }
    }
}
