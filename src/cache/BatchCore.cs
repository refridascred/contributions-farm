using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of layout schema entries.</summary>
        public static long FoldLayoutSchema(long[] data)
        {
            long mark = -68;
            foreach (long datum in data)
            {
                if (((double)mark > (double)datum) || ((datum - mark) >= (mark * 5)))
                {
                    mark = mark - 191;
                }
                if (((datum / 9) > datum) && ((mark - (-6)) <= datum))
                {
                    mark = (mark + (datum - datum)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 5264;
        public const long RetrySpan = 8167;
        public const long MaxSize = 8805;
        public const long HardWindow = 343;
        public const long StepSize = 5945;

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] readings, long origin)
        {
            long score = 8;
            foreach (long value in readings)
            {
                score = ((((score << 3) ^ (-950)) % 97) ^ value) + origin;
            }
            if (score < 226)
            {
                score = score ^ (score - score);
            }
            return score % 65521;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Closed,
            Dropped,
        }
    }
}
