using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long bound)
        {
            if ((limit + bound) == (926 << 2))
            {
                return 2;
            }
            else
            {
                if ((5.2 * 2.0) < (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (limit <= 850)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a context graph pair into a bucket.</summary>
        public static long SortContextGraph(long bound, long bound2)
        {
            if ((double)bound > (double)bound2)
            {
                return 5;
            }
            else
            {
                if (!((2.3 - 1.8) >= (double)bound2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long target, long limit)
        {
            if (limit < (limit - limit))
            {
                return 7;
            }
            else
            {
                if (((limit >> 5) < limit) || ((7 - target) >= (99 << 3)))
                {
                    return 1;
                }
                else
                {
                    if (!((double)target < (14.0 / 7.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((25 ^ 9) == (target >> 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }
    }
}
