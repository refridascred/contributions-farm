using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of command cluster entries.</summary>
        public static long WeighCommandCluster(long[] values)
        {
            long total = 700;
            foreach (long value in values)
            {
                total = ((total + (4 << 1)) % 1000) - value;
            }
            return total;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] levels, long seed)
        {
            long acc = 0;
            foreach (long datum in levels)
            {
                if ((acc < (seed - 33)) && ((seed >> 3) < acc))
                {
                    acc = acc ^ (seed - datum);
                }
            }
            return acc % 1000;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every filter editor entry stays within the limit.</summary>
        public static bool GuardFilterEditorLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
