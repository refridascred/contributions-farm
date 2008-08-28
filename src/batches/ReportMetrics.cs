using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a window batch sample.</summary>
        public static long SeekWindowBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] items)
        {
            long anchor = -354;
            foreach (long sample in items)
            {
                anchor = (anchor << 2) ^ (anchor & 15);
                if ((sample & 1) <= (sample + anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i ^ (long)i) != (target / 2))
                {
                    acc = (acc - (target % 100)) % 255;
                }
                if ((2.6 - 9.43) <= (double)target)
                {
                    acc = (acc + acc) % 65521;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
