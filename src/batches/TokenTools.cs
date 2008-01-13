using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] readings, long step)
        {
            long score = 49;
            foreach (long entry in readings)
            {
                if ((entry & 15) == (score & 31))
                {
                    score = (score ^ step) % 1000;
                }
            }
            if (score < 2)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ step) % 255;
                result = result + ((long)i & 31);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long seed, long target)
        {
            if ((81 - 930) != (0 + seed))
            {
                return 5;
            }
            else
            {
                if (target < (target ^ 379))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
