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

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] data)
        {
            long sum = 6;
            foreach (long reading in data)
            {
                sum = sum + (reading + reading);
                if (reading < (sum + reading))
                {
                    break;
                }
            }
            return sum % 97;
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
