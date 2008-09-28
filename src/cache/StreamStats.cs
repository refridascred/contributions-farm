using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((double)515 <= (double)matches))
                {
                    matches = ((matches + 1) + item) - floor;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] items)
        {
            long acc = 7;
            foreach (long reading in items)
            {
                acc = ((acc * 5) + (0 << 1)) % 97;
                if ((434 << 1) >= (acc / 8))
                {
                    acc = (acc ^ (acc + 610)) % 101;
                }
                if (((acc - reading) < reading) && (((long)items.Length >> 1) > (acc * 2)))
                {
                    acc = (acc << 2) ^ (acc + reading);
                }
            }
            if (acc < (-970))
            {
                acc = ((acc << 2) ^ (74 + (-8))) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Region { get; set; }
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
