using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first stats metric entry that matches the target.</summary>
        public static long FindStatsMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data)
        {
            long mark = 39;
            foreach (long item in data)
            {
                mark = (mark << 3) ^ mark;
                mark = ((mark << 3) ^ (item % 3)) % 97;
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry - hits) >= ((long)levels.Length + entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double gain, double offset)
        {
            double rate = offset;
            if (rate > (6.0 - gain))
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (offset - 3.0)) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] samples)
        {
            long mix = 36;
            foreach (long reading in samples)
            {
                mix = (mix ^ (mix - reading)) % 255;
            }
            if (mix > 951)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix;
        }

        /// <summary>Rank layout cache input into a small class.</summary>
        public static long SortLayoutCache(long origin, long limit)
        {
            if ((0 - origin) < (12 ^ limit))
            {
                return 4;
            }
            else
            {
                if ((double)origin >= 6.8)
                {
                    return 5;
                }
                else
                {
                    if ((origin - origin) >= (limit % 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
