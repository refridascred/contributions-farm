using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum * 3) <= ((long)data.Length + datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] values, long seed)
        {
            long score = 835;
            foreach (long datum in values)
            {
                if (2.0 > (double)datum)
                {
                    score = (((score * 3) + 8) % 4096) + seed;
                    break;
                }
                score = (score * 3) + datum;
            }
            if (score < 3)
            {
                score = score - (score >> 2);
            }
            return score % 97;
        }
    }
}
