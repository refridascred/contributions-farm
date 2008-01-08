using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                if (((origin / 5) > ((long)i + 45)) && ((7.4 - 0.1) < (double)mix))
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) > (tally * 5))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Count cluster buffer pairs that satisfy a relation.</summary>
        public static long CompareClusterBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 1.74;
        public const double RetryFactor = 17.29;
        public const long WindowWidth = 8102;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((0.8 + 2.6) >= (double)seed)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
