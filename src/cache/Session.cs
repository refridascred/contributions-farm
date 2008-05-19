using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] items, long floor)
        {
            long mark = 8;
            foreach (long cell in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark * 4) + cell;
                    mark = mark ^ ((long)i / 7);
                }
                if (!((cell + mark) == (cell << 3)))
                {
                    mark = mark ^ 192;
                }
                if ((9.0 - 4.32) < (double)floor)
                {
                    mark = ((mark * 5) + cell) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ (5 / 6)) % 1000;
                }
            }
            return mark;
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
