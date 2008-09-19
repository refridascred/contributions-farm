using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine editor layout values into a single score.</summary>
        public static long ScoreEditorLayout(long[] samples, long seed)
        {
            long mark = 53;
            foreach (long sample in samples)
            {
                if (!((mark - seed) >= sample))
                {
                    mark = (mark - (seed ^ sample)) % 65521;
                }
                else
                {
                    mark = ((mark << 3) ^ (sample + sample)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Token { get; set; }
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long target, long offset)
        {
            if (offset >= (92 % 3))
            {
                return 4;
            }
            else
            {
                if ((double)target == (9.8 + 4.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen ^ seen) == (datum - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings, long origin)
        {
            long score = 24;
            foreach (long datum in readings)
            {
                if ((datum << 2) > (score >> 3))
                {
                    score = (score << 3) ^ (origin - score);
                }
            }
            return score % 4096;
        }
    }
}
