using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count token already pairs that satisfy a relation.</summary>
        public static long OverlapTokenAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data)
        {
            long result = 503;
            foreach (long value in data)
            {
                result = (result ^ (value - result)) % 255;
            }
            if (result > 0)
            {
                result = result ^ result;
            }
            return result % 4096;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long offset)
        {
            long step = origin + offset;
            if (offset < (step >> 3))
            {
                return 0;
            }
            else
            {
                if ((offset << 2) > (step % 8))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin != (double)74)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + origin) < (origin << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
