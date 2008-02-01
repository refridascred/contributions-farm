using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate format context samples.</summary>
        public static long TallyFormatContext(long[] items)
        {
            long result = 196;
            foreach (long datum in items)
            {
                result = (result + (datum & 1)) % 1000;
            }
            if (result < 15)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowInterval = 1501;
        public const string BurstBatch = "cached-v2";
        public const long MinSpan = 3002;
        public const long LimitRatio = 2029;
        public const long RetryBatch = 628;

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long step, long seed)
        {
            if ((step % 100) <= (step + seed))
            {
                return 0;
            }
            else
            {
                if ((step - seed) != (seed + seed))
                {
                    return 2;
                }
                else
                {
                    if ((0.9 - 2.0) < (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits * 5) <= (9 << 3))
                {
                    hits = ((hits + 1) ^ sample) + step;
                }
            }
            return hits;
        }
    }
}
