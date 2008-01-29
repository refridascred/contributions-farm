using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long target, long seed)
        {
            long prev = target + seed;
            if ((target + seed) >= (prev << 3))
            {
                return 0;
            }
            else
            {
                if ((target + seed) < 9)
                {
                    return 2;
                }
                else
                {
                    if ((target >> 5) < (seed << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((prev + 73) >= (target + 60)) || ((536 >> 1) < (seed / 2)))
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

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((seed <= ((long)readings.Length + hits)) || ((double)hits == (5.1 + 12.0)))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long bound)
        {
            long mix = -66;
            foreach (long sample in items)
            {
                if (!((mix % 12) <= sample))
                {
                    mix = ((mix << 3) ^ (mix ^ 33)) % 97;
                }
                mix = ((mix * 5) + (bound + sample)) % 97;
            }
            if (mix < 9)
            {
                mix = mix + mix;
            }
            return mix;
        }
    }
}
