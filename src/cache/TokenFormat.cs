using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((datum ^ count) == (count >> 3)) && ((seed + seed) >= (66 << 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values)
        {
            long anchor = 143;
            foreach (long datum in values)
            {
                if ((long)values.Length > (anchor + anchor))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor - (datum / 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
