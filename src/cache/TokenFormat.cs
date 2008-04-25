using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many order farm samples are out of range.</summary>
        public static long CountOrderFarmMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((origin + cell) >= (count * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target ^ target) <= total)
                {
                    total = ((total * 3) + ((long)i << 2)) % 4096;
                }
                total = total - (target * 2);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
