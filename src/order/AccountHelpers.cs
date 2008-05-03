using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of githubfarm entry readings.</summary>
        public static long OverlapGithubfarmEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)bound >= 6.7)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if ((5.52 * 8.49) >= (double)cell)
                {
                    score = (score + score) % 255;
                }
                else
                {
                    score = (score - score) % 101;
                }
            }
            return score;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((2 & 255) < (value >> 5))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next batch layout value from a seed.</summary>
        public static long RollBatchLayout(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = acc + limit;
                if (((long)i << 2) >= (long)i)
                {
                    acc = acc ^ ((long)i & 3);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
