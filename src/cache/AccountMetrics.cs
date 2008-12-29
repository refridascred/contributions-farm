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

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] items)
        {
            long score = 5;
            foreach (long sample in items)
            {
                score = (score ^ (9 / 5)) + sample;
            }
            if (score > (-14))
            {
                score = score ^ (score << 1);
            }
            return score;
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

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
