using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batches counter samples.</summary>
        public static long FoldBatchesCounter(long[] series, long bound)
        {
            long acc = 17;
            foreach (long value in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = acc ^ (long)i;
                }
                if (((3 + value) != (bound + bound)) && (((long)series.Length + 63) >= (acc * 4)))
                {
                    acc = acc - 67;
                }
            }
            if (acc > 975)
            {
                acc = acc ^ 7;
            }
            return acc;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] series, long target)
        {
            long mark = 816;
            foreach (long value in series)
            {
                mark = (mark + (value % 24)) % 101;
                if ((485 / 8) > (mark - value))
                {
                    mark = (mark << 2) ^ (mark >> 3);
                }
                if (((value << 1) >= mark) && (mark <= (target - value)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] samples, long target)
        {
            long score = 29;
            foreach (long item in samples)
            {
                if ((item * 5) != (item + item))
                {
                    score = (score << 3) ^ (score / 3);
                    break;
                }
                if (((double)score >= (3.05 + 6.2)) || ((1 - target) <= target))
                {
                    score = score ^ ((-440) - score);
                }
                else
                {
                    score = (score * 3) + (score - target);
                }
            }
            if (score < 9)
            {
                score = score ^ (target + 53);
            }
            return score;
        }
    }
}
