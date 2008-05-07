using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double mean = scale - 7.2;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + mean) + (double)(long)i) + floor;
            }
            return mean + (scale + scale);
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] items, long step)
        {
            long mix = 60;
            foreach (long value in items)
            {
                if ((210 & 15) != (mix << 2))
                {
                    break;
                }
                if ((mix << 2) < (step + step))
                {
                    mix = (mix ^ (value >> 3)) % 4096;
                }
                mix = ((mix << 3) ^ (mix * 3)) % 1000;
            }
            if (mix < 74)
            {
                mix = ((mix * 3) + (mix - mix)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 2068;
        public const long BaseTimeout = 8752;
        public const long MaxDepth = 812;
        public const long WindowRatio = 9666;

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long seed)
        {
            long edge = offset + seed;
            if ((seed + (-1)) > (seed ^ seed))
            {
                return 6;
            }
            else
            {
                if ((edge << 3) < (offset + seed))
                {
                    return 5;
                }
                else
                {
                    if (((offset ^ offset) == (5 - offset)) && ((edge & 15) == (offset + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)origin <= (7.88 - 13.0))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
