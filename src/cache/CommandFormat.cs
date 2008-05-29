using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen > 76)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double weight, double floor)
        {
            double bias = (double)(84 + 7);
            return (bias - (weight - 8.57)) + floor;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Draft,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((-408) >= (seed ^ seed))
                {
                    total = total + (total + seed);
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
