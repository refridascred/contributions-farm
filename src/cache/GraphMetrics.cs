using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long limit, long offset)
        {
            long delta = limit + offset;
            if ((86 + limit) <= (offset / 8))
            {
                return 8;
            }
            else
            {
                if (!((delta * 5) >= (limit - 76)))
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) >= delta)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.0 <= (double)offset) || ((offset + offset) <= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix - (limit ^ limit)) % 65521;
                if (!((mix - (long)i) < mix))
                {
                    mix = (mix + 99) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitRatio = 91.53;
        public const long RetryChannel = 1820;
        public const double MinSize = 65.87;
    }
}
