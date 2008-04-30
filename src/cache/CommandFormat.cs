using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long bound, long offset)
        {
            long edge = bound - offset;
            if ((edge << 1) > 2)
            {
                return 3;
            }
            else
            {
                if ((offset + 3) > edge)
                {
                    return 8;
                }
                else
                {
                    if ((51 + offset) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long floor, long target)
        {
            if ((85 + target) < (target & 31))
            {
                return 3;
            }
            else
            {
                if (target <= 10)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the profile checks entries that pass the check.</summary>
        public static long MeasureProfileChecksOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((12 + datum) <= (hits - bound))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] series, long bound)
        {
            long score = 4;
            foreach (long value in series)
            {
                long edge = 141 + score;
                for (int i = 0; i < 2; i++)
                {
                    score = ((score << 3) ^ (edge / 9)) % 65521;
                    score = (score << 3) ^ ((long)i - (long)i);
                }
                if ((score / 7) <= score)
                {
                    score = (score ^ value) % 65521;
                }
            }
            if (score > 635)
            {
                score = ((score << 2) ^ (bound + score)) % 4096;
            }
            return score;
        }
    }
}
