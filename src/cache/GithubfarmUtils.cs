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

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((mix % 8) >= mix))
                {
                    mix = mix - mix;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Draft,
            Queued,
            Done,
            Pending,
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
