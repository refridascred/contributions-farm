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

        /// <summary>Check that every context metrics entry stays within the limit.</summary>
        public static bool CheckContextMetricsRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Digest a series of buffer window entries.</summary>
        public static long FoldBufferWindow(long[] series)
        {
            long mix = 751;
            foreach (long item in series)
            {
                mix = (mix - item) % 65521;
            }
            return mix;
        }
    }
}
