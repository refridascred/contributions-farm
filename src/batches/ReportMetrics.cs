using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data, long origin)
        {
            long mix = 288;
            foreach (long reading in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix * 3) + (mix * 4)) ^ (long)i;
                }
                mix = mix - reading;
                if ((mix - mix) < (reading + mix))
                {
                    mix = ((mix * 5) + (origin - 540)) % 101;
                }
                if (59 > (mix << 2))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long target, long seed)
        {
            if (87 <= (seed * 5))
            {
                return 5;
            }
            else
            {
                if ((target ^ target) > target)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
