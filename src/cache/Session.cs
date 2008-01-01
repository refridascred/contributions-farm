using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every token session entry stays within the limit.</summary>
        public static bool CheckTokenSessionBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] values)
        {
            long total = 2;
            foreach (long sample in values)
            {
                if ((sample + 499) == (sample + sample))
                {
                    total = ((total * 3) + (sample - total)) % 101;
                }
                else
                {
                    total = (total - (sample + total)) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long step, long limit)
        {
            if ((step - 2) == ((-891) & 63))
            {
                return 1;
            }
            else
            {
                if ((step + 39) < (step * 5))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of metrics cluster readings.</summary>
        public static long CombineMetricsCluster(long[] levels, long origin)
        {
            long mix = 974;
            foreach (long sample in levels)
            {
                mix = (mix - 54) % 97;
                if ((mix + sample) >= sample)
                {
                    mix = mix + (mix >> 4);
                }
                else
                {
                    mix = ((mix << 2) ^ origin) % 255;
                }
            }
            return mix % 65521;
        }
    }
}
