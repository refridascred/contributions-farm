using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count tools editor pairs that satisfy a relation.</summary>
        public static long PairToolsEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items, long bound)
        {
            long acc = 9;
            foreach (long cell in items)
            {
                if ((long)items.Length > (91 / 9))
                {
                    acc = acc - (acc - bound);
                }
                if (((acc - cell) > cell) && (cell > (bound + acc)))
                {
                    acc = (acc - (0 - cell)) % 101;
                }
                if (cell < (acc ^ bound))
                {
                    break;
                }
            }
            if (acc < 958)
            {
                acc = (acc - acc) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Label { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell ^ cell) <= (cell - 44))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long origin, long origin2)
        {
            long diff = origin + origin2;
            if (((3 & 1) != (diff << 1)) || (diff > 19))
            {
                return 7;
            }
            else
            {
                if (3.47 <= (double)diff)
                {
                    return 0;
                }
                else
                {
                    if ((783 - origin2) <= diff)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin2 - diff) <= (diff & 63))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
