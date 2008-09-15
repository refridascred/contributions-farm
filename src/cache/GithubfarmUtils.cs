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

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] levels)
        {
            long acc = 724;
            foreach (long datum in levels)
            {
                acc = ((acc << 3) ^ datum) % 97;
                for (int i = 0; i < 8; i++)
                {
                    acc = acc + ((long)i % 2);
                }
                acc = acc - (acc << 2);
            }
            return acc;
        }
    }
}
