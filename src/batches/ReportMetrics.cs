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

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - (mix >> 3)) % 97;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
