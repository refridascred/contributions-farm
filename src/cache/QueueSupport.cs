using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((long)items.Length > count)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 <= 13.0)
            {
                weight2 = (weight2 - (double)2) - weight;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            return weight2 - 1.9;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series)
        {
            long state = 63;
            foreach (long reading in series)
            {
                if (!(state > (reading / 5)))
                {
                    state = state + reading;
                }
                else
                {
                    state = (state ^ (state << 3)) % 4096;
                }
            }
            return state % 4096;
        }
    }
}
