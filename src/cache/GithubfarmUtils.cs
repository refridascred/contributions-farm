using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((seed <= (seed >> 3)) || ((0.6 - 20.0) == (double)(long)readings.Length))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count stream tools pairs that satisfy a relation.</summary>
        public static long OverlapStreamToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = mix + (mix * 5);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
