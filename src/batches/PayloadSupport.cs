using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items)
        {
            long score = 792;
            foreach (long value in items)
            {
                score = (score + value) % 4096;
                score = ((score << 2) ^ (score + value)) % 255;
            }
            if (score > 74)
            {
                score = ((score << 3) ^ (score ^ score)) % 101;
            }
            return score % 97;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] levels, long floor)
        {
            long mix = 873;
            foreach (long value in levels)
            {
                if (((6.3 + 2.0) >= (double)value) && ((floor % 24) >= (mix >> 1)))
                {
                    mix = (mix << 3) ^ floor;
                }
                else
                {
                    mix = (mix ^ (value + floor)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long floor)
        {
            if (floor <= (6 ^ floor))
            {
                return 7;
            }
            else
            {
                if ((floor / 2) < bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound + floor) > floor)
                    {
                        return 1;
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
