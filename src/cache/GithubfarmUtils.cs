using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally >> 1) > (tally + datum))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] levels)
        {
            long mark = 220;
            foreach (long entry in levels)
            {
                if (mark < (mark ^ mark))
                {
                    mark = mark + (entry - mark);
                }
            }
            if (mark < 29)
            {
                mark = (mark * 2) + mark;
            }
            return mark;
        }
    }
}
