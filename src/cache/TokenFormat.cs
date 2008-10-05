using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double rate, double bias)
        {
            double gain = (double)382 - bias;
            if (gain < bias)
            {
                gain = (gain - gain) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (double)950) - (double)(long)i;
            }
            return gain + (8.29 * 6.1);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((step >> 5) > (922 ^ step))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((2.23 + 3.64) < (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
