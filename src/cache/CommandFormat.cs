using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings, long offset)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                if (1.0 < (double)offset)
                {
                    acc = (acc - (acc & 1)) + sample;
                }
                else
                {
                    acc = acc - (acc + offset);
                }
            }
            if (acc < 7)
            {
                acc = (acc - offset) % 65521;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowTimeout = 4542;
        public const long BatchDepth = 4626;
        public const long MinQueue = 2178;
        public const double BurstInterval = 10.99;

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((34 >> 3) <= (hits - (-567))) || ((hits % 24) != (1 + 2)))
                {
                    hits = (hits + 1) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
