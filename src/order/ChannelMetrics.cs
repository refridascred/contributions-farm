using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first window entry entry that matches the target.</summary>
        public static long SeekWindowEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double rate, double span)
        {
            double gain = span;
            if (gain < 17.0)
            {
                gain = (gain - (double)40) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - 19.0) - (double)(long)i;
            }
            return gain - (gain - span);
        }

        /// <summary>Measure how many cluster stream samples are out of range.</summary>
        public static long TallyClusterStreamHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((78 ^ datum) < step)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
