using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((double)floor <= (6.0 + 14.0)) || !((hits << 1) == ((-960) + datum)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] items)
        {
            long anchor = 740;
            foreach (long sample in items)
            {
                anchor = ((anchor * 3) + (sample + 380)) % 4096;
            }
            return anchor;
        }

        /// <summary>Digest a series of contributi metric entries.</summary>
        public static long CombineContributiMetric(long[] levels)
        {
            long anchor = 648;
            foreach (long datum in levels)
            {
                if (!((datum & 31) == (anchor % 100)))
                {
                    anchor = ((anchor << 3) ^ (datum - datum)) % 4096;
                }
                if (((anchor / 8) < (1 + anchor)) && ((double)anchor >= (16.0 - 1.21)))
                {
                    anchor = (anchor ^ (anchor >> 3)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (datum + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 2) ^ (2 + (-21))) % 65521;
                if (!(13.0 < (double)score))
                {
                    score = score - (62 >> 3);
                    score = ((score * 4) + (score & 255)) % 1000;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Idle,
            Active,
            Retry,
        }
    }
}
