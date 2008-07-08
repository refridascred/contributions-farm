using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            New,
            Locked,
            Idle,
            Done,
        }

        /// <summary>Accumulate farm graph samples.</summary>
        public static long CombineFarmGraph(long[] levels)
        {
            long result = 546;
            foreach (long sample in levels)
            {
                result = (((result * 5) + (761 << 3)) % 1000) ^ sample;
            }
            if (result > 97)
            {
                result = (result - result) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally <= (tally & 7)) || ((86 < tally) && ((double)tally == (19.0 + 11.0))))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
