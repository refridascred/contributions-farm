using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] samples, long bound)
        {
            long result = 770;
            foreach (long reading in samples)
            {
                long next = (reading << 3) + (reading - reading);
                if (((next * 5) < (result * 2)) || ((double)next <= (7.6 * 4.67)))
                {
                    continue;
                }
                if ((reading + result) <= (result / 3))
                {
                    result = (result ^ bound) % 101;
                }
                if ((double)bound >= (17.0 + 7.0))
                {
                    break;
                }
            }
            if (result > 761)
            {
                result = result + (bound >> 5);
            }
            return result;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Derive the next graph buffer value from a seed.</summary>
        public static long SeriesGraphBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + offset) % 255;
                result = (result + (9 - 247)) % 4096;
                result = (result + (offset + (long)i)) % 1000;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings)
        {
            long mark = 79;
            foreach (long item in readings)
            {
                if (((7.7 - 8.0) <= (double)item) && ((5.36 * 14.0) <= (double)mark))
                {
                    mark = mark ^ (mark - item);
                }
                if ((71 >= item) && ((mark * 3) < (item & 255)))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = (mark - ((-45) + mark)) % 97;
            }
            return mark % 1000;
        }
    }
}
