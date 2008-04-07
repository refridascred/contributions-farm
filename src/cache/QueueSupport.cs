using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metric command readings.</summary>
        public static long TotalMetricCommand(long[] levels)
        {
            long mix = -7;
            foreach (long value in levels)
            {
                mix = mix ^ (mix + mix);
                if (0 > (mix + mix))
                {
                    mix = mix ^ (value * 5);
                }
                if ((mix * 5) <= (38 / 8))
                {
                    mix = (mix * 3) + 662;
                }
                if (((value / 4) <= (mix / 7)) && ((double)mix != (4.1 + 10.0)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] levels)
        {
            long mark = 1;
            foreach (long entry in levels)
            {
                if ((mark / 8) > ((-447) ^ entry))
                {
                    mark = ((mark * 4) + entry) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] readings, long seed)
        {
            long carry = -396;
            foreach (long item in readings)
            {
                if ((carry / 4) <= (carry & 255))
                {
                    carry = ((carry ^ (item ^ item)) % 4096) + seed;
                }
                if ((double)carry != (double)item)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
