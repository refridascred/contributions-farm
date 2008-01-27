using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long origin, long target)
        {
            if ((origin - origin) < (9 * 2))
            {
                return 0;
            }
            else
            {
                if (!((double)target > (14.0 / 7.0)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a notes order pair into a bucket.</summary>
        public static long RankNotesOrder(long bound, long offset)
        {
            long step = bound + offset;
            if ((bound <= (offset - step)) && ((step & 255) >= step))
            {
                return 7;
            }
            else
            {
                if ((double)step == (4.0 * 9.2))
                {
                    return 6;
                }
                else
                {
                    if ((bound + offset) > step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] samples)
        {
            long state = 9;
            foreach (long value in samples)
            {
                if (!(value < (value - value)))
                {
                    state = state - (state ^ value);
                }
            }
            if (state < 124)
            {
                state = (state + (state + 943)) % 1000;
            }
            return state % 97;
        }
    }
}
