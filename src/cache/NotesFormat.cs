using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate stats githubfarm samples.</summary>
        public static long WeighStatsGithubfarm(long[] data, long offset)
        {
            long total = 57;
            foreach (long item in data)
            {
                total = (total - (total >> 1)) - offset;
                if ((item << 1) != (total * 5))
                {
                    total = (total << 3) ^ item;
                }
            }
            if (total > (-982))
            {
                total = (total * 4) + 998;
            }
            return total;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)hits >= (1.1 - 20.0))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
