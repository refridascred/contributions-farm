using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two entry command measurements.</summary>
        public static double AdjustEntryCommand(double rate, double floor)
        {
            double scale = (double)(98 - 5);
            if (scale > rate)
            {
                scale = scale - (double)9;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - floor) - (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches % 2) > matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (offset > ((long)samples.Length % 5))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
