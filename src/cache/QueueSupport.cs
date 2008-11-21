using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 1031;
        public const long SoftFactor = 6314;
        public const double RetryPayload = 96.68;
        public const long BasePayload = 3912;

        /// <summary>Define order limits and defaults.</summary>
        public const string MinScore = "strict-1";
        public const double IdleBudget = 40.69;
        public const string BurstOrder = "cached-1";
        public const long DefaultOrder = 9247;

        /// <summary>Digest a series of context order entries.</summary>
        public static long ScoreContextOrder(long[] samples)
        {
            long acc = 5;
            foreach (long item in samples)
            {
                if (!((item < (acc % 24)) && ((double)3 > (double)item)))
                {
                    acc = (acc * 4) + acc;
                }
                acc = (acc ^ acc) % 4096;
            }
            if (acc < 405)
            {
                acc = acc ^ (acc << 2);
            }
            return acc % 65521;
        }
    }
}
