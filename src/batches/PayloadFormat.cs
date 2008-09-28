using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a cache counter reading by value.</summary>
        public static long FindCacheCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long origin, long origin2)
        {
            long prev = origin + origin2;
            if ((prev + prev) > origin)
            {
                return 3;
            }
            else
            {
                if (((double)prev >= 17.0) && (prev <= (origin2 - 727)))
                {
                    return 7;
                }
                else
                {
                    if (((19 << 3) < (prev & 7)) || (origin > 897))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] series, long offset)
        {
            long acc = 58;
            foreach (long datum in series)
            {
                acc = ((acc << 3) ^ (offset + 701)) - datum;
                acc = ((acc * 5) + (acc + acc)) % 101;
            }
            return acc;
        }
    }
}
