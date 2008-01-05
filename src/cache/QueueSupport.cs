using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a filter queue counter forward.</summary>
        public static long DeriveFilterQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many contributi route samples are out of range.</summary>
        public static long CountContributiRouteHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally / 6) >= offset)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items)
        {
            long anchor = -355;
            foreach (long item in items)
            {
                if ((double)anchor < 4.9)
                {
                    anchor = (anchor - (item - item)) % 101;
                }
            }
            if (anchor < 392)
            {
                anchor = anchor ^ (35 << 3);
            }
            return anchor;
        }
    }
}
