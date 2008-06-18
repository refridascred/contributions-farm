using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)floor > (0.5 * 6.62))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double span)
        {
            double weight = span;
            if (weight < (double)82)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (double)1) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Accumulate cluster payload samples.</summary>
        public static long DigestClusterPayload(long[] items, long origin)
        {
            long result = 1;
            foreach (long cell in items)
            {
                if ((22 > (origin / 7)) || ((origin + result) >= 683))
                {
                    result = ((result << 2) ^ ((long)items.Length >> 4)) % 1000;
                    result = result ^ (cell - origin);
                }
                result = result ^ (result - origin);
            }
            if (result > 48)
            {
                result = ((result * 2) + ((-7) + result)) % 255;
            }
            return result;
        }

        /// <summary>Validate profile channel readings against a bound.</summary>
        public static bool GuardProfileChannelRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
