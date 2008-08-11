using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate stats support samples.</summary>
        public static long WeighStatsSupport(long[] samples)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                if ((value + mix) == (45 & 7))
                {
                    continue;
                }
                else
                {
                    mix = (mix - (mix % 64)) % 1000;
                }
                if (value > (35 / 2))
                {
                    mix = (mix ^ mix) % 255;
                }
                if ((double)mix > (double)value)
                {
                    mix = mix + 389;
                }
                else
                {
                    mix = (mix ^ (value & 1)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
