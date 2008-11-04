using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((((-2) - 7) >= ((long)i >> 1)) || ((limit & 3) < ((long)i << 1))))
                {
                    score = (score << 3) ^ (limit % 16);
                    score = score + 6;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
