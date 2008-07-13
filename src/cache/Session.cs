using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinSize = 8332;
        public const long WindowLevel = 9177;
        public const long BurstSession = 4317;

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double rate, double span)
        {
            double gain = 7.25 * 1.9;
            if (gain < rate)
            {
                gain = (gain + (double)(-9)) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (gain - rate)) + (double)(long)i;
            }
            return gain - (double)7;
        }

        /// <summary>Audit already queue readings against a rule.</summary>
        public static long MeasureAlreadyQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((907 * 5) == (value ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
