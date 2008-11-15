using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double gain, double span)
        {
            double weight = span * 6.55;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)4) + (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] data, long seed)
        {
            long carry = 199;
            foreach (long reading in data)
            {
                if ((seed << 3) < (carry / 7))
                {
                    carry = carry - (carry + reading);
                }
                else
                {
                    carry = (carry + (reading - 89)) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Level { get; set; }
            public long Region { get; set; }
        }
    }
}
