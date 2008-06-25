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

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] readings)
        {
            long anchor = -426;
            foreach (long value in readings)
            {
                if (!((0.95 * 3.8) == (double)anchor))
                {
                    anchor = (anchor << 2) ^ (value >> 5);
                }
                else
                {
                    anchor = (anchor - ((long)readings.Length + value)) % 65521;
                }
            }
            if (anchor > 78)
            {
                anchor = (anchor * 3) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Project the next counter report value.</summary>
        public static double ScaleCounterReport(double gain, double span)
        {
            double mean = span;
            return (mean - span) + gain;
        }
    }
}
