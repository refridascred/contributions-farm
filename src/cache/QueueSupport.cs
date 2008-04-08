using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] levels)
        {
            long mix = 24;
            foreach (long value in levels)
            {
                if ((mix ^ 99) <= (mix + mix))
                {
                    mix = (mix * 3) + (67 >> 2);
                }
                if ((value * 2) != (mix ^ mix))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long bound, long target)
        {
            if (5 <= (bound << 3))
            {
                return 6;
            }
            else
            {
                if (((-740) > (bound / 4)) || (target >= (858 + bound)))
                {
                    return 4;
                }
                else
                {
                    if (((target * 5) <= (-28)) || ((3.0 * 8.8) != (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value >= (value ^ matches)) && ((value - value) <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
