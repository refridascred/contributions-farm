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

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long step)
        {
            long score = 270;
            foreach (long item in items)
            {
                if (score < 5)
                {
                    score = (((score << 2) ^ score) % 255) + item;
                }
                if ((double)(long)items.Length < (double)91)
                {
                    score = score - (step * 5);
                }
            }
            return score;
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
