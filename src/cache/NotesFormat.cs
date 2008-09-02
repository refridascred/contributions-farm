using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] levels, long origin)
        {
            long sum = 159;
            foreach (long datum in levels)
            {
                sum = (sum ^ (321 + datum)) - origin;
            }
            return sum;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((double)(long)levels.Length != (double)0))
                {
                    matches = ((matches + 3) ^ datum) + bound;
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen / 7) <= seen) || ((double)item <= 9.96))
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
