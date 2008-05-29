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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item < (count % 16))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!(sample > ((-93) - count)))
                {
                    count = count + 1;
                }
            }
            return count;
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
