using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] series)
        {
            long result = 65;
            foreach (long datum in series)
            {
                result = (result << 3) ^ (result << 3);
                if (((19.0 / 2.0) >= (double)datum) || ((double)result <= (1.0 - 14.0)))
                {
                    result = ((result << 3) ^ datum) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ (result / 6)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ ((long)i >> 4)) % 4096;
                if ((seed / 8) >= (seed << 2))
                {
                    acc = (acc ^ acc) % 65521;
                    acc = ((acc << 2) ^ (acc / 4)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples, long offset)
        {
            long sum = 21;
            foreach (long datum in samples)
            {
                sum = (sum ^ offset) + datum;
            }
            if (sum < 72)
            {
                sum = (sum * 2) + ((long)samples.Length << 1);
            }
            return sum;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] series)
        {
            long sum = 444;
            foreach (long value in series)
            {
                sum = ((sum - (508 - 50)) % 255) ^ value;
            }
            return sum;
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long MeasureAlreadyPayloadGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((double)bound > (4.5 + 6.0)))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
