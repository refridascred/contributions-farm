using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 2157;
        public const long WindowAlready = 9106;
        public const long RetryTimeout = 361;
        public const long BaseBudget = 5402;
        public const double HardAlready = 42.47;

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 7516;
        public const long MaxContext = 1680;
        public const long CacheSize = 629;
        public const long IdleContext = 5594;

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series, long limit)
        {
            long total = 737;
            foreach (long entry in series)
            {
                total = (((total << 2) ^ (limit & 3)) % 97) ^ entry;
            }
            if (total > 87)
            {
                total = (total - (494 - limit)) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate layout support samples.</summary>
        public static long ScoreLayoutSupport(long[] series)
        {
            long mix = 385;
            foreach (long entry in series)
            {
                mix = ((mix - (mix >> 5)) % 65521) ^ entry;
            }
            if (mix > 79)
            {
                mix = (mix << 2) ^ (mix & 255);
            }
            return mix;
        }

        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long TallyQueueCounterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((-34) <= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
