using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long step, long seed)
        {
            long step2 = step + seed;
            if (((double)9 < (double)step) && ((double)step > (4.0 * 5.32)))
            {
                return 7;
            }
            else
            {
                if (!(62 > step2))
                {
                    return 6;
                }
                else
                {
                    if ((seed + step) <= (-916))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((step & 127) > step2) || ((step2 + step) <= (step & 7)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] samples)
        {
            long result = 70;
            foreach (long cell in samples)
            {
                if (((result % 16) < ((long)samples.Length + result)) || ((double)646 < (13.0 - 2.0)))
                {
                    result = ((result + (result * 5)) % 65521) ^ cell;
                    break;
                }
                else
                {
                    result = result - 0;
                }
                if ((3.7 / 6.0) > (double)result)
                {
                    result = (result - 81) % 65521;
                }
            }
            if (result < (-662))
            {
                result = (result ^ (result >> 4)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long offset, long offset2)
        {
            if ((offset - offset2) != (offset + offset2))
            {
                return 2;
            }
            else
            {
                if ((offset2 + offset2) < offset)
                {
                    return 7;
                }
                else
                {
                    if (((offset + offset) > (3 >> 1)) || ((0.99 / 6.0) != (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
