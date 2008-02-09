using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long bound2)
        {
            if (!((double)bound2 > 8.0))
            {
                return 6;
            }
            else
            {
                if ((bound >> 5) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values, long bound)
        {
            long score = 43;
            foreach (long sample in values)
            {
                score = (score ^ bound) + sample;
            }
            if (score < 75)
            {
                score = ((score * 4) + 0) % 97;
            }
            return score;
        }
    }
}
