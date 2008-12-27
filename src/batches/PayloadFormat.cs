using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] series)
        {
            long mix = 1;
            foreach (long cell in series)
            {
                mix = ((mix << 3) ^ (cell + cell)) % 97;
                mix = (mix ^ mix) % 4096;
            }
            if (mix < 1)
            {
                mix = (mix ^ (84 >> 4)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Locate a filter format reading by value.</summary>
        public static long FindFilterFormatIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value << 1) > (value ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank batch support input into a small class.</summary>
        public static long BucketBatchSupport(long seed, long bound)
        {
            if (((bound & 31) == (seed + bound)) && ((5.5 - 0.3) >= (double)bound))
            {
                return 2;
            }
            else
            {
                if (((1.4 * 0.13) == (double)seed) || ((bound >> 1) > (seed ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if (!((4.2 / 2.0) <= (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.87 * 7.06) <= (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
