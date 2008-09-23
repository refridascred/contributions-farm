using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of command graph readings.</summary>
        public static long ScoreCommandGraph(long[] items, long floor)
        {
            long anchor = 8;
            foreach (long reading in items)
            {
                anchor = (anchor - (reading * 3)) % 255;
                anchor = (anchor * 2) + (floor + 450);
            }
            if (anchor < 933)
            {
                anchor = anchor + (9 + floor);
            }
            return anchor;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long target)
        {
            long score = target;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the counter route entries that pass the check.</summary>
        public static long CountCounterRouteHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((0 << 1) == (reading * 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
