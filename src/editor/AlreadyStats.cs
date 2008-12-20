using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count * 4) <= (count + count))
                {
                    count = ((count + 3) + entry) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the buffer graph series from a seed.</summary>
        public static long StepBufferGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((total + total) > (bound ^ (long)i)) && (bound > 22))
                {
                    total = ((total * 4) + (long)i) % 65521;
                    continue;
                }
                else
                {
                    total = ((total << 2) ^ total) % 255;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
