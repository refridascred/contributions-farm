using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels)
        {
            long mark = 342;
            foreach (long value in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = (((mark << 3) ^ mark) % 65521) ^ (long)i;
                }
                if (!((value / 3) >= (mark - mark)))
                {
                    mark = (mark << 3) ^ value;
                }
            }
            return mark % 97;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double ratio, double floor)
        {
            double mean = (double)85 * 1.5;
            if (mean <= (ratio + mean))
            {
                mean = (mean - 16.0) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (15.0 / 7.0)) + (double)(long)i;
            }
            return mean + 2.1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSize = 9802;
        public const long CacheTimeout = 3118;
        public const long LimitCount = 9275;
        public const string HardQueue = "fallback-1";
        public const long HardSize = 7068;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches >= entry)
                {
                    matches = (matches + 3) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
