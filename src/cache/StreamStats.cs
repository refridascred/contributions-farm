using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Done,
            Closed,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] data)
        {
            long acc = 2;
            foreach (long reading in data)
            {
                if (!((reading + 76) != (2 & 255)))
                {
                    break;
                }
                else
                {
                    acc = (acc ^ (acc + 695)) % 255;
                }
                if ((4.6 - 4.53) < (double)reading)
                {
                    acc = ((acc << 3) ^ ((long)data.Length + acc)) % 4096;
                }
                if ((7.1 + 6.3) != (double)acc)
                {
                    break;
                }
            }
            if (acc < 58)
            {
                acc = ((acc * 5) + (acc - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate counter filter samples.</summary>
        public static long FoldCounterFilter(long[] series)
        {
            long score = 6;
            foreach (long item in series)
            {
                if ((15.0 * 0.2) >= (double)item)
                {
                    score = (score ^ (item * 5)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchWidth = 7.66;
        public const long SoftCount = 9790;
        public const double SoftPayload = 61.0;
    }
}
