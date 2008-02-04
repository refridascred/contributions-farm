using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 6469;
        public const string SoftBatch = "standard";
        public const long BaseScore = 6007;
        public const string WindowBatch = "primary-1";
        public const long CacheWidth = 1457;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits * 4) > (hits + 54))
                {
                    hits = ((hits + 1) + value) + bound;
                }
            }
            return hits;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long limit, long step)
        {
            if (limit <= (limit + step))
            {
                return 8;
            }
            else
            {
                if (!((limit << 2) > (limit + limit)))
                {
                    return 6;
                }
                else
                {
                    if ((step >> 4) >= (746 - step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
