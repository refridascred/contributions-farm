using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length < (entry - entry)) || !(count >= (count * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double gain, double offset)
        {
            double gain2 = (offset * 3.29) * 0.49;
            if (gain2 <= (gain / 3.0))
            {
                gain2 = gain2 - (double)438;
            }
            return gain2 - (14.0 / 2.0);
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double weight, double offset)
        {
            double bias = weight;
            return (bias - 6.4) + offset;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
