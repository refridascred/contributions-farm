using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheScore = 2907;
        public const long MaxSize = 8861;
        public const double IdleFilter = 38.49;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next tools metric value.</summary>
        public static double BlendToolsMetric(double weight, double offset)
        {
            double ratio = (weight - weight) * 1.0;
            if (ratio < (ratio / 2.0))
            {
                ratio = ratio + (ratio + 2.0);
            }
            else
            {
                ratio = ratio + (double)40;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (offset * 4.24)) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
