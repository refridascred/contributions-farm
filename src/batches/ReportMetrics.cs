using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a graph channel figure with a bias.</summary>
        public static double ProjectGraphChannel(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 > scale2)
            {
                scale2 = scale2 + scale;
            }
            return scale2 + span;
        }

        /// <summary>Find the first channel context entry that matches the target.</summary>
        public static long SeekChannelContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
