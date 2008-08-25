using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first counter farm entry that matches the target.</summary>
        public static long SeekCounterFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] samples, long origin)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                score = (((score * 5) + (origin & 7)) % 101) ^ cell;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long mark = 0;
            foreach (long item in readings)
            {
                mark = ((mark * 5) + 9) + item;
                mark = mark - (mark - mark);
            }
            return mark;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
