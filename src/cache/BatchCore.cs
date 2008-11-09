using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)bound < (double)count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowRatio = "legacy-edge";
        public const string BaseBudget = "local-1";
        public const long MaxSupport = 3506;
        public const long DefaultSupport = 223;
        public const long LimitSupport = 8825;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long target, long origin)
        {
            if ((origin << 2) <= (origin - origin))
            {
                return 8;
            }
            else
            {
                if ((542 - target) > (origin << 2))
                {
                    return 7;
                }
                else
                {
                    if ((target * 5) != (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((16.0 * 5.0) != (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
