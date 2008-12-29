using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of farm metrics readings.</summary>
        public static long DigestFarmMetrics(long[] samples)
        {
            long mark = -40;
            foreach (long datum in samples)
            {
                if (((mark + mark) >= mark) || (((long)samples.Length ^ datum) < (datum ^ 4)))
                {
                    mark = (mark + (mark + mark)) % 4096;
                    continue;
                }
                if ((datum ^ mark) >= datum)
                {
                    mark = (mark * 2) + 42;
                }
                mark = ((mark * 3) + (55 - mark)) % 1000;
                if (((mark / 2) <= (mark % 10)) && (datum >= 745))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long bound, long origin)
        {
            if ((origin % 5) >= (912 - 23))
            {
                return 8;
            }
            else
            {
                if (bound < origin)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitDepth = 8496;
        public const double BatchPayload = 86.64;
        public const long SoftPayload = 5652;
        public const long BasePayload = 8371;
        public const long WindowSize = 666;

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheSpan = 27.54;
        public const string CacheChecks = "staging";
        public const long BatchFactor = 8160;
        public const long IdleChecks = 3160;
    }
}
