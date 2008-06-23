using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a editor already pair into a bucket.</summary>
        public static long BucketEditorAlready(long origin, long seed)
        {
            if ((double)origin >= (16.0 + 2.9))
            {
                return 2;
            }
            else
            {
                if ((3.1 < (double)origin) || ((285 / 4) < origin))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 1) != (origin / 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a queue window value against two limits.</summary>
        public static long ClassifyQueueWindow(long floor, long origin)
        {
            if ((9.73 / 4.0) < (double)origin)
            {
                return 6;
            }
            else
            {
                if (origin < floor)
                {
                    return 4;
                }
                else
                {
                    if (((floor * 2) != (floor & 1)) && ((floor + 8) != (floor << 2)))
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

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
        }
    }
}
