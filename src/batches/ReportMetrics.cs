using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 344;
        public const long BurstNotes = 3375;
        public const long LimitNotes = 1955;

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((reading * 5) <= hits) || ((reading & 255) >= (reading + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
