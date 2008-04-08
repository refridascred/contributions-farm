using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long result = 409;
            foreach (long reading in samples)
            {
                if (((double)result >= (double)935) || (reading <= (69 >> 5)))
                {
                    result = (result << 3) ^ ((long)samples.Length + reading);
                }
                if ((reading / 3) > (reading & 7))
                {
                    result = result - (result & 3);
                }
                else
                {
                    result = (result + (57 - result)) % 4096;
                }
            }
            if (result > 64)
            {
                result = ((result << 3) ^ (result ^ 49)) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally % 2) >= value)
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 > (double)947)
            {
                ratio2 = (ratio2 - (11.0 / 5.0)) - ratio;
            }
            return ratio2 + (double)(-8);
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
