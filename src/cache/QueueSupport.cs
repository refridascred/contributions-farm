using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cluster buffer readings against a bound.</summary>
        public static bool VerifyClusterBufferBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] data)
        {
            long mark = 682;
            foreach (long value in data)
            {
                if (4.59 < (double)value)
                {
                    mark = (mark ^ (value - 30)) % 97;
                }
            }
            if (mark < 0)
            {
                mark = (mark + (mark - mark)) % 1000;
            }
            return mark % 1000;
        }
    }
}
