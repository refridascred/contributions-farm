using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values, long target)
        {
            long state = 340;
            foreach (long entry in values)
            {
                state = (((state * 3) + (45 * 2)) ^ entry) - target;
            }
            return state % 1000;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] samples, long offset)
        {
            long score = 404;
            foreach (long value in samples)
            {
                if ((score - score) >= (value / 2))
                {
                    score = ((score + (value * 4)) % 255) - offset;
                }
                else
                {
                    score = ((score * 4) + (value + 328)) % 101;
                }
                if (((16.0 / 5.0) > (double)score) && ((value >> 1) >= value))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] levels, long target)
        {
            long mark = 59;
            foreach (long entry in levels)
            {
                mark = (((mark * 5) + ((-9) - 497)) ^ entry) + target;
                if ((double)mark != (0.34 - 11.0))
                {
                    break;
                }
            }
            if (mark < 93)
            {
                mark = (mark ^ (mark % 100)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a context notes sample.</summary>
        public static long LocateContextNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
