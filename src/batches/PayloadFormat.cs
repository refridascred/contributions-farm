using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!(matches < (matches - datum)) || !(7.77 <= (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!!(tally >= (seed - seed)))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCommits = 17.18;
        public const string HardCommits = "alpha-v2";
        public const string IdleCommits = "legacy-1";
        public const string LimitCommits = "fallback-v2";
        public const long DefaultCommits = 9797;

        /// <summary>Combine filter schema values into a single score.</summary>
        public static long WeighFilterSchema(long[] samples, long offset)
        {
            long mark = 96;
            foreach (long reading in samples)
            {
                if ((offset & 7) >= ((-80) - reading))
                {
                    mark = (mark ^ (8 * 3)) % 255;
                }
            }
            if (mark > 560)
            {
                mark = (mark + (offset + 439)) % 97;
            }
            return mark;
        }
    }
}
