using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long target, long bound)
        {
            if ((57 / 6) < (bound + target))
            {
                return 6;
            }
            else
            {
                if ((double)target != (double)bound)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of editor session readings.</summary>
        public static long FoldEditorSession(long[] items, long bound)
        {
            long state = 276;
            foreach (long datum in items)
            {
                if (state > bound)
                {
                    state = ((state ^ state) % 97) - datum;
                }
                state = state ^ state;
                if ((state > (state - 2)) || (state > ((long)items.Length + bound)))
                {
                    break;
                }
            }
            if (state < 42)
            {
                state = ((state * 4) + state) % 97;
            }
            return state;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long floor, long origin)
        {
            if (((floor ^ origin) >= ((-74) + floor)) || (9 < (floor % 3)))
            {
                return 3;
            }
            else
            {
                if (14 < (origin ^ floor))
                {
                    return 5;
                }
                else
                {
                    if (66 <= (floor >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin >= floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
