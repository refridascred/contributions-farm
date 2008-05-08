using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] items, long target)
        {
            long score = 2;
            foreach (long cell in items)
            {
                if (!((0.8 / 6.0) != (double)score))
                {
                    score = (score ^ score) - cell;
                }
                else
                {
                    score = (score * 2) + (target - score);
                }
            }
            return score;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long origin, long bound)
        {
            if (bound <= (origin - origin))
            {
                return 2;
            }
            else
            {
                if (!((8.0 - 9.98) >= (double)bound))
                {
                    return 5;
                }
                else
                {
                    if ((origin <= (origin / 4)) && ((bound & 255) != (404 + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound < origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
