using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value / 2) > 882)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double weight, double offset)
        {
            double scale = offset + (5.5 * 5.1);
            if (scale > (offset - offset))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - weight) - (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Paused,
            Pending,
        }
    }
}
