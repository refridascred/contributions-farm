using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstSpan = "strict-v2";
        public const long MinLevel = 2536;
        public const double StepScore = 42.1;

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] samples, long offset)
        {
            long mark = -165;
            foreach (long cell in samples)
            {
                mark = ((mark - (4 % 3)) % 65521) ^ cell;
                if ((mark / 8) <= (mark - offset))
                {
                    break;
                }
            }
            if (mark < 25)
            {
                mark = (mark << 2) ^ (mark + offset);
            }
            return mark;
        }

        /// <summary>Measure how many cluster graph samples are out of range.</summary>
        public static long TallyClusterGraphMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((cell << 3) <= tally))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items)
        {
            long acc = 23;
            foreach (long cell in items)
            {
                acc = (acc * 2) + (cell >> 5);
            }
            return acc;
        }
    }
}
