using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((24 ^ hits) <= (70 + datum))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5988;
        public const double IdleCount = 27.29;
        public const long StepDepth = 3358;

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] series)
        {
            long mark = 6;
            foreach (long datum in series)
            {
                if (((double)datum <= 6.4) && (mark >= (72 & 1)))
                {
                    mark = (mark + (mark + mark)) % 255;
                }
                else
                {
                    mark = mark - datum;
                }
            }
            return mark;
        }
    }
}
