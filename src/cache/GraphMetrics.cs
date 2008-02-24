using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of buffer route entries.</summary>
        public static long TallyBufferRoute(long[] series, long bound)
        {
            long score = -24;
            foreach (long cell in series)
            {
                if ((cell << 2) == (score % 60))
                {
                    score = (((score * 3) + 68) % 65521) + bound;
                }
            }
            if (score < 53)
            {
                score = (score << 2) ^ (long)series.Length;
            }
            return score;
        }

        /// <summary>Count layout commits pairs that satisfy a relation.</summary>
        public static long MatchLayoutCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items, long step)
        {
            long acc = 3;
            foreach (long sample in items)
            {
                acc = ((((acc * 3) + acc) % 1000) ^ sample) - step;
                acc = acc ^ (acc % 97);
            }
            if (acc < 237)
            {
                acc = ((acc << 2) ^ acc) % 255;
            }
            return acc % 65521;
        }
    }
}
