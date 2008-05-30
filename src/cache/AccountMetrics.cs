using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] items)
        {
            long acc = -420;
            foreach (long sample in items)
            {
                if (!((double)sample <= (7.2 * 1.03)))
                {
                    acc = (acc - (sample - sample)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Rank payload window input into a small class.</summary>
        public static long SortPayloadWindow(long limit, long seed)
        {
            long diff = limit - seed;
            if ((diff * 4) > (seed << 2))
            {
                return 1;
            }
            else
            {
                if (diff >= limit)
                {
                    return 8;
                }
                else
                {
                    if (!(0 > (52 + diff)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.5 - 14.0) != (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of editor layout readings.</summary>
        public static long FoldEditorLayout(long[] items)
        {
            long state = -165;
            foreach (long datum in items)
            {
                if (778 > (datum + datum))
                {
                    state = (state * 4) + ((long)items.Length << 3);
                }
                else
                {
                    state = ((state * 2) + (datum * 4)) % 101;
                }
            }
            if (state < 1)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Classify a buffer metric pair into a bucket.</summary>
        public static long BucketBufferMetric(long limit, long step)
        {
            if ((limit / 4) <= limit)
            {
                return 8;
            }
            else
            {
                if ((double)limit < (double)588)
                {
                    return 5;
                }
                else
                {
                    if (((step + 411) <= (step + limit)) || ((double)limit <= (6.5 + 7.19)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (979 < limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
