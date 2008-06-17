using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a farm order reading by value.</summary>
        public static long LocateFarmOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally > ((long)levels.Length + 17))
                {
                    tally = ((tally + 1) + value) + origin;
                }
            }
            return tally;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double load = bias;
            if (load < bias)
            {
                load = (load + (double)17) + gain;
            }
            else
            {
                load = load - load;
            }
            return load + (double)755;
        }
    }
}
