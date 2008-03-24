using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = (score + (long)i) % 255;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long step)
        {
            if ((bound + bound) == (bound & 3))
            {
                return 3;
            }
            else
            {
                if ((bound / 9) != (step + step))
                {
                    return 2;
                }
                else
                {
                    if (!(bound > (bound % 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
