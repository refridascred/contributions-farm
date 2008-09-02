using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] series)
        {
            long acc = 855;
            foreach (long sample in series)
            {
                if (!((acc >> 4) != (932 * 2)))
                {
                    acc = (acc * 2) + acc;
                }
                if ((acc - sample) != (43 * 3))
                {
                    acc = (acc - (acc + 5)) % 101;
                }
                else
                {
                    acc = (acc + (sample + sample)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Count stats commits pairs that satisfy a relation.</summary>
        public static long OverlapStatsCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((17 >> 5) <= entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
