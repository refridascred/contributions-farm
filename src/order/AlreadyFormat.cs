using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] items)
        {
            long score = 6;
            foreach (long entry in items)
            {
                score = score + (score ^ entry);
                if ((entry + entry) > score)
                {
                    score = (score ^ entry) % 1000;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of contributi queue readings.</summary>
        public static long PairContributiQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank record command input into a small class.</summary>
        public static long GradeRecordCommand(long target, long floor)
        {
            long gap = target + floor;
            if ((double)floor != (9.0 - 11.0))
            {
                return 2;
            }
            else
            {
                if ((gap - gap) > target)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}
