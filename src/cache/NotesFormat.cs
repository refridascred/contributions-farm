using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate account filter readings against a bound.</summary>
        public static bool CheckAccountFilterBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                total = ((total << 3) ^ (offset % 64)) % 1000;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
