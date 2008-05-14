using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a editor context sample.</summary>
        public static long SeekEditorContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the token order entries that pass the check.</summary>
        public static long MeasureTokenOrderOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= 4.0)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double ratio, double floor)
        {
            double weight = (double)(0 << 2);
            if (weight >= 12.0)
            {
                weight = ((weight + 6.9) + ratio) - floor;
            }
            return weight + 14.0;
        }
    }
}
