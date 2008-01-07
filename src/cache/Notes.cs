using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = (score + (score + score)) % 65521;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] series, long origin)
        {
            long mark = 73;
            foreach (long item in series)
            {
                if (((mark / 8) == (mark % 10)) && ((item * 3) <= mark))
                {
                    mark = ((mark - ((long)series.Length + item)) % 101) - origin;
                }
            }
            return mark % 97;
        }

        /// <summary>Iterate the format batch series from a seed.</summary>
        public static long RollFormatBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = (total ^ (total - limit)) % 4096;
                if (((long)i / 5) < (long)i)
                {
                    total = (total - 1) % 255;
                    break;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Total { get; set; }
            public double Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long origin, long offset)
        {
            if ((11.0 / 3.0) <= (double)origin)
            {
                return 4;
            }
            else
            {
                if (offset < (offset >> 5))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
