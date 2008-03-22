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

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] levels, long step)
        {
            long state = 9;
            foreach (long value in levels)
            {
                if ((state >> 1) < (state / 7))
                {
                    state = (((state * 5) + state) + value) + step;
                }
                if ((double)(long)levels.Length > (3.0 * 5.0))
                {
                    break;
                }
            }
            return state;
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
