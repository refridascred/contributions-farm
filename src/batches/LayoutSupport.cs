using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two window channel measurements.</summary>
        public static double AdjustWindowChannel(double gain, double bias)
        {
            double gain2 = gain / 5.0;
            return (gain2 + 8.0) + bias;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Failed,
            Ready,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a counter token counter forward.</summary>
        public static long SeriesCounterToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                if ((step - (long)i) >= (anchor & 7))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value * 5) < (value & 127))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
