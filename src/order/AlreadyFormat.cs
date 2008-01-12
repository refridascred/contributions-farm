using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] data)
        {
            long acc = 532;
            foreach (long sample in data)
            {
                if (3.2 < (double)sample)
                {
                    acc = (acc ^ sample) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of graph metric entries.</summary>
        public static long TotalGraphMetric(long[] readings)
        {
            long mix = 936;
            foreach (long entry in readings)
            {
                mix = ((mix * 5) + (mix - entry)) % 1000;
                mix = (mix + entry) % 255;
                if ((0.79 - 18.0) < (double)mix)
                {
                    mix = mix ^ (mix - mix);
                }
                if (entry > (entry ^ 363))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the entry stats entries that pass the check.</summary>
        public static long AuditEntryStatsOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally > (tally / 8)) && !((sample + 617) >= (target % 24)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Synced,
            New,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                long diff = state;
                if (!((19.0 * 8.81) >= (double)diff))
                {
                    state = ((state * 5) + (diff - (long)i)) % 1000;
                }
                state = ((state * 2) + (state - offset)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
