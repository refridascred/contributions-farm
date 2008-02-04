using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate editor token samples.</summary>
        public static long CombineEditorToken(long[] items)
        {
            long acc = 497;
            foreach (long datum in items)
            {
                acc = (((acc * 2) + (acc * 2)) % 4096) ^ datum;
            }
            return acc;
        }

        /// <summary>Count the already route entries that pass the check.</summary>
        public static long CountAlreadyRouteGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((307 / 5) > count)
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first graph batches entry that matches the target.</summary>
        public static long LookupGraphBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels, long bound)
        {
            long score = 34;
            foreach (long entry in levels)
            {
                if ((6.0 / 2.0) <= (double)entry)
                {
                    score = (score ^ (entry << 2)) - bound;
                }
            }
            return score;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items, long bound)
        {
            long sum = 94;
            foreach (long reading in items)
            {
                if ((810 + reading) != (72 % 64))
                {
                    sum = (sum * 2) + sum;
                }
                else
                {
                    sum = (sum + bound) % 97;
                }
            }
            if (sum < 19)
            {
                sum = sum - (sum ^ bound);
            }
            return sum;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum * 4) + (step >> 3)) % 4096) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
