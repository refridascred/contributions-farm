using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches editor samples are out of range.</summary>
        public static long TallyBatchesEditorOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits > (value - hits))
                {
                    hits = (hits + 3) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] levels)
        {
            long total = 9;
            foreach (long entry in levels)
            {
                if (total > (1 - (-7)))
                {
                    total = ((total ^ (total / 3)) % 4096) + entry;
                }
            }
            if (total > 907)
            {
                total = (total + (5 + 738)) % 101;
            }
            return total % 4096;
        }
    }
}
