using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((hits + limit) > (limit << 3)) && ((datum / 9) < (limit >> 4))) && !(limit <= (hits / 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the session cluster entries that pass the check.</summary>
        public static long MeasureSessionClusterHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)4 == (double)entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Pending,
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Combine editor context values into a single score.</summary>
        public static long FoldEditorContext(long[] series, long floor)
        {
            long acc = 9;
            foreach (long entry in series)
            {
                acc = (((acc << 2) ^ (floor ^ floor)) % 97) + entry;
            }
            return acc;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
