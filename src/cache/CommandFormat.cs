using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((86 - hits) != (3 + hits))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double gain, double floor)
        {
            double load = 15.0;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (double)(long)i) - gain) - floor;
            }
            return load - load;
        }
    }
}
