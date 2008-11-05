using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 10.4;
        public const long CacheCommand = 5871;
        public const string BurstSpan = "latest-1";

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((10.0 * 13.0) == (double)(long)readings.Length)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long score = 0;
            foreach (long reading in items)
            {
                score = ((score * 4) + score) % 4096;
                if (!((658 << 3) <= (reading % 97)))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
