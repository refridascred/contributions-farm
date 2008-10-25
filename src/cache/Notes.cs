using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] levels, long bound)
        {
            long total = 115;
            foreach (long item in levels)
            {
                total = ((total ^ (bound - total)) % 1000) - item;
                total = (total ^ (total % 97)) % 101;
            }
            if (total > 262)
            {
                total = ((total << 2) ^ (447 >> 4)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] samples, long floor)
        {
            long acc = 399;
            foreach (long cell in samples)
            {
                if (!((floor - 889) > (cell & 1)))
                {
                    acc = (acc + cell) % 97;
                }
            }
            if (acc < 856)
            {
                acc = (acc ^ (acc + acc)) % 4096;
            }
            return acc;
        }
    }
}
