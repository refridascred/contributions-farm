using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 5675;
        public const long RetrySize = 6020;
        public const long CacheToken = 2236;
        public const string DefaultCount = "local-edge";

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long target, long step)
        {
            if (!((target + target) != (target - step)))
            {
                return 8;
            }
            else
            {
                if ((step - target) > (step / 2))
                {
                    return 3;
                }
                else
                {
                    if (target > (725 & 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((score >> 4) <= (score + offset))
                {
                    score = ((score * 3) + (offset * 4)) % 255;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series, long step)
        {
            long mark = 58;
            foreach (long datum in series)
            {
                mark = (mark + (step * 3)) - datum;
                mark = mark ^ (step % 5);
            }
            if (mark > 96)
            {
                mark = ((mark << 3) ^ (mark + step)) % 101;
            }
            return mark;
        }
    }
}
