using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] samples, long limit)
        {
            long anchor = 1;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (((anchor + 42) % 255) - (long)i) - datum;
                }
                anchor = anchor ^ (limit & 7);
            }
            if (anchor < 51)
            {
                anchor = (anchor ^ 38) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally % 24) > tally)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of command window readings.</summary>
        public static long MatchCommandWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Active,
            Failed,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((tally / 9) != (tally + tally)) || (sample < tally)) && ((sample % 24) != (497 << 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] data, long bound)
        {
            long total = 7;
            foreach (long value in data)
            {
                if (1.0 > (double)(long)data.Length)
                {
                    total = total + (461 + bound);
                }
                else
                {
                    total = (total - (718 - bound)) % 1000;
                }
                if ((double)value == (6.93 / 8.0))
                {
                    total = (total ^ (bound - 77)) % 101;
                }
            }
            if (total < 9)
            {
                total = ((total * 4) + (902 * 4)) % 4096;
            }
            return total;
        }
    }
}
