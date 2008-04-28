using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Dropped,
            Stale,
            New,
            Queued,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings)
        {
            long anchor = 446;
            foreach (long cell in readings)
            {
                anchor = ((anchor * 2) + 62) % 101;
                if ((double)cell != (8.4 / 8.0))
                {
                    anchor = (anchor << 3) ^ cell;
                }
                else
                {
                    anchor = (anchor ^ (2 + 295)) % 255;
                }
            }
            if (anchor < (-7))
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Measure how many notes metrics samples are out of range.</summary>
        public static long MeasureNotesMetricsMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 2) >= offset)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of githubfarm batch readings.</summary>
        public static long MatchGithubfarmBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
