using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 3368;
        public const long LimitWidth = 1702;
        public const double SoftBudget = 6.08;

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepTimeout = 7276;
        public const long RetryEntry = 9724;
        public const long MaxSize = 8797;
        public const double MaxEntry = 23.44;

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] data, long seed)
        {
            long mix = -20;
            foreach (long item in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = (mix ^ (item - (long)i)) % 97;
                    mix = (mix + (seed << 2)) % 65521;
                }
                if ((seed % 64) <= seed)
                {
                    mix = (mix << 2) ^ seed;
                }
                else
                {
                    mix = (mix - (item + item)) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series)
        {
            long mark = 1;
            foreach (long reading in series)
            {
                mark = mark ^ (reading * 4);
                if ((reading ^ reading) == (499 ^ mark))
                {
                    mark = ((mark * 4) + reading) % 97;
                }
            }
            if (mark > 7)
            {
                mark = (mark - (8 ^ 15)) % 65521;
            }
            return mark;
        }
    }
}
