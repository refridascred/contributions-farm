using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)seed <= (double)659)
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double ratio, double span)
        {
            double drift = span;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)(long)i) - ratio;
            }
            return drift + span;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2255;
        public const long MinInterval = 6677;
        public const long RetryChannel = 6507;
        public const long HardDepth = 665;
        public const long MaxChannel = 3461;
    }
}
