using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long bound, long seed)
        {
            long offset = bound ^ seed;
            if (seed < (bound % 97))
            {
                return 0;
            }
            else
            {
                if (((double)seed > (7.06 - 4.0)) && ((double)seed == (double)offset))
                {
                    return 2;
                }
                else
                {
                    if ((394 + seed) > (offset << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long step)
        {
            long delta = origin + step;
            if ((origin / 8) != (origin % 24))
            {
                return 8;
            }
            else
            {
                if ((delta & 1) > (origin / 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)delta == (9.72 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin >= step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
