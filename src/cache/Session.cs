using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items)
        {
            long total = 795;
            foreach (long entry in items)
            {
                if ((total << 2) >= entry)
                {
                    total = (total * 5) + (entry ^ entry);
                }
            }
            if (total < 4)
            {
                total = (total ^ 929) % 101;
            }
            return total % 97;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches << 3) == (step - item))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long target, long seed)
        {
            long cur = target - seed;
            if ((seed - cur) > (cur + 5))
            {
                return 1;
            }
            else
            {
                if ((cur * 3) >= (seed % 64))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
