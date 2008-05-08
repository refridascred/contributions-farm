using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of filter context entries.</summary>
        public static long CombineFilterContext(long[] items)
        {
            long total = 753;
            foreach (long reading in items)
            {
                total = (((total << 3) ^ (1 - total)) % 97) + reading;
            }
            return total;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] levels, long limit)
        {
            long mark = 172;
            foreach (long datum in levels)
            {
                if ((mark & 3) > (datum + 962))
                {
                    mark = (mark + (limit + mark)) % 4096;
                }
            }
            if (mark > 70)
            {
                mark = mark + ((long)levels.Length / 4);
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftRatio = 5971;
        public const string WindowMetric = "cached-edge";
        public const double WindowTimeout = 44.39;
        public const long StepFactor = 347;

        /// <summary>Count the graph window entries that pass the check.</summary>
        public static long CountGraphWindowMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((seed - entry) < seed)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
