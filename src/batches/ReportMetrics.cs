using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 9744;
        public const long StepAlready = 6059;
        public const double CacheAlready = 95.81;

        /// <summary>Combine editor stream values into a single score.</summary>
        public static long TotalEditorStream(long[] samples, long origin)
        {
            long acc = 702;
            foreach (long cell in samples)
            {
                if (((14.0 / 7.0) == (double)cell) && (origin >= (cell >> 2)))
                {
                    break;
                }
                if ((cell << 2) >= (acc - cell))
                {
                    acc = ((acc * 3) + (acc + origin)) % 97;
                }
                else
                {
                    acc = (acc - acc) % 65521;
                }
            }
            if (acc > (-6))
            {
                acc = (acc << 3) ^ (58 ^ origin);
            }
            return acc;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
