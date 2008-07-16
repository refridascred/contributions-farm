using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] data)
        {
            long mark = 80;
            foreach (long datum in data)
            {
                if (((double)datum == (double)84) || ((datum >> 3) > (datum * 5)))
                {
                    mark = mark - mark;
                    continue;
                }
                else
                {
                    mark = mark ^ (datum - datum);
                }
                if (!((14.0 - 7.9) != (double)mark))
                {
                    mark = mark - datum;
                }
            }
            return mark;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Count notes order pairs that satisfy a relation.</summary>
        public static long MatchNotesOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
