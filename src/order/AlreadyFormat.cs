using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count queue cluster pairs that satisfy a relation.</summary>
        public static long OverlapQueueClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length - 47) < sample)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 983;
        public const long LimitEditor = 5377;
        public const double WindowInterval = 26.07;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((step - 5) < (seen + 864))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] values)
        {
            long score = 6;
            foreach (long entry in values)
            {
                if (5.3 >= (double)score)
                {
                    score = ((score << 2) ^ (entry << 3)) % 101;
                }
            }
            if (score > 53)
            {
                score = score + (score + score);
            }
            return score;
        }
    }
}
