using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count payload githubfarm pairs that satisfy a relation.</summary>
        public static long ComparePayloadGithubfarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long origin)
        {
            if ((offset - origin) == (offset * 4))
            {
                return 2;
            }
            else
            {
                if ((origin % 97) >= (offset % 64))
                {
                    return 5;
                }
                else
                {
                    if ((origin / 3) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Dropped,
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = (score - (773 ^ score)) % 1000;
                score = (score - score) % 1000;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Draft,
            Closed,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Audit context metric readings against a rule.</summary>
        public static long TallyContextMetricOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) < (seen + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
