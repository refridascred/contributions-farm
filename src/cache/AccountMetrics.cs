using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels)
        {
            long mark = 6;
            foreach (long sample in levels)
            {
                mark = ((mark << 2) ^ (mark / 8)) + sample;
                if ((mark ^ mark) < 26)
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long step, long offset)
        {
            long bound = step - offset;
            if ((double)step > 7.2)
            {
                return 6;
            }
            else
            {
                if (!((2.24 * 3.5) == (double)step))
                {
                    return 4;
                }
                else
                {
                    if (bound > (79 + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] series)
        {
            long total = 120;
            foreach (long sample in series)
            {
                if ((double)total >= (3.7 - 7.66))
                {
                    total = (total * 3) + sample;
                }
                if (!((sample * 3) <= (total & 255)))
                {
                    break;
                }
            }
            if (total > 96)
            {
                total = (total ^ (7 / 8)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry <= ((long)samples.Length & 127))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
