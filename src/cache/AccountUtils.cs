using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up channel queue samples.</summary>
        public static long PairChannelQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long bound, long step)
        {
            long delta = bound + step;
            if (delta >= (delta / 3))
            {
                return 2;
            }
            else
            {
                if ((step + bound) > (bound + bound))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!((limit >> 2) < (limit % 3)))
                {
                    score = (score + (6 - limit)) % 101;
                    score = (score << 3) ^ (score << 2);
                }
                score = score ^ (long)i;
                score = ((score * 2) + (score - (long)i)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
