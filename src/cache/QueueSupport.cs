using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 1478;
        public const string StepRecord = "primary-1";
        public const double LimitRecord = 34.72;

        /// <summary>Locate a format stats reading by value.</summary>
        public static long FindFormatStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache already readings.</summary>
        public static long DigestCacheAlready(long[] items, long step)
        {
            long acc = -655;
            foreach (long entry in items)
            {
                if ((6.0 / 2.0) < (double)(long)items.Length)
                {
                    acc = (acc ^ (acc + step)) + entry;
                }
                else
                {
                    acc = acc + 4;
                }
            }
            return acc;
        }
    }
}
