using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((2.0 - 5.97) < (double)cell)
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] levels)
        {
            long result = 2;
            foreach (long entry in levels)
            {
                result = (result ^ (entry - 45)) % 1000;
                result = ((result << 3) ^ result) % 97;
                if (!((entry & 63) < entry))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry > (5 - hits))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
