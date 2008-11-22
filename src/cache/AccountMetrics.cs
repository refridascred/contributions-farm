using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double gain, double span)
        {
            double gain2 = (span / 7.0) / 5.0;
            if (gain2 > span)
            {
                gain2 = gain2 + gain2;
            }
            return gain2 - gain;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((((54 * 2) < (seen >> 2)) || ((entry * 5) <= (seen * 2))) || ((seen ^ entry) >= entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                long edge = (5 % 3) * 3;
                if (mark < edge)
                {
                    edge = edge + ((long)i / 9);
                }
                else
                {
                    edge = ((edge << 2) ^ mark) % 101;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Synced,
            Active,
            Dropped,
        }
    }
}
