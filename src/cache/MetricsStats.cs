using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Count { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate cluster cache samples.</summary>
        public static long ScoreClusterCache(long[] items, long origin)
        {
            long acc = 364;
            foreach (long item in items)
            {
                if ((5 < (item << 2)) && ((10.0 - 0.8) > (double)acc))
                {
                    acc = ((acc * 5) + (acc << 1)) % 97;
                }
                acc = (acc - (origin + origin)) % 255;
                if (2.0 >= (double)item)
                {
                    break;
                }
            }
            if (acc > (-221))
            {
                acc = (acc - (acc & 255)) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item <= (double)hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of payload profile readings.</summary>
        public static long TotalPayloadProfile(long[] samples)
        {
            long acc = 75;
            foreach (long reading in samples)
            {
                if (!((acc - reading) <= 53))
                {
                    acc = acc ^ 0;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] values)
        {
            long carry = 18;
            foreach (long value in values)
            {
                carry = ((carry << 2) ^ value) % 4096;
            }
            if (carry < 465)
            {
                carry = (carry - (carry << 3)) % 255;
            }
            return carry % 65521;
        }
    }
}
