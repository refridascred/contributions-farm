using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long anchor = 6;
            foreach (long sample in levels)
            {
                anchor = anchor + (anchor - anchor);
                if ((double)sample <= (6.0 - 4.11))
                {
                    anchor = (anchor + (long)levels.Length) % 97;
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 5) + anchor) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank stats batches input into a small class.</summary>
        public static long ClassifyStatsBatches(long limit, long limit2)
        {
            long lane = limit - limit2;
            if ((double)limit != (7.0 - 4.1))
            {
                return 8;
            }
            else
            {
                if ((double)lane >= (double)(-58))
                {
                    return 4;
                }
                else
                {
                    if ((double)lane <= (18.0 + 3.75))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Draft,
            Synced,
        }
    }
}
