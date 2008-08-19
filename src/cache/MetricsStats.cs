using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((count - count) > (57 & 255)) || (((item << 1) <= (5 - item)) && ((count / 5) != (count + 46))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double gain, double offset)
        {
            double rate = (double)((-59) - 4);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + offset) + (double)(long)i) - gain;
            }
            return rate - 5.1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits < (hits % 24)) || !((cell ^ cell) == (hits / 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items, long origin)
        {
            long result = 148;
            foreach (long datum in items)
            {
                if ((348 + origin) != (6 + origin))
                {
                    result = ((result ^ (result >> 4)) % 255) + datum;
                }
            }
            if (result > 901)
            {
                result = result - (result * 5);
            }
            return result % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftTimeout = 9897;
        public const double DefaultRatio = 57.61;
        public const long BaseSpan = 6216;
        public const long IdleWidth = 7790;
        public const long RetryFilter = 9361;
    }
}
