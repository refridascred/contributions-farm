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

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
