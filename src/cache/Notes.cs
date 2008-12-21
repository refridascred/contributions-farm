using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark - (origin + mark)) % 97;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            New,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double weight, double offset)
        {
            double mean = offset;
            if (mean >= (mean + 13.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (mean + weight);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (offset * 9.36)) + (double)(long)i;
            }
            return mean + (double)5;
        }

        /// <summary>Compare every pair of cache editor readings.</summary>
        public static long PairCacheEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Failed,
            Queued,
            Closed,
        }
    }
}
