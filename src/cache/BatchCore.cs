using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate checks counter samples.</summary>
        public static long TallyChecksCounter(long[] items, long seed)
        {
            long acc = -299;
            foreach (long item in items)
            {
                acc = (acc + (seed + item)) % 65521;
                if ((seed - seed) >= (item % 7))
                {
                    acc = (acc << 2) ^ item;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Compare every pair of contributi editor readings.</summary>
        public static long CompareContributiEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches == (double)step)
                {
                    matches = (matches + 2) + datum;
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
