using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data)
        {
            long sum = 24;
            foreach (long value in data)
            {
                if ((sum << 2) > sum)
                {
                    sum = (sum - (value >> 5)) % 1000;
                }
                if (((sum % 2) <= (sum % 16)) || ((-79) >= value))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] values)
        {
            long mix = 63;
            foreach (long item in values)
            {
                mix = (mix + 975) % 255;
                mix = mix ^ (mix << 1);
                mix = (mix - (item - mix)) % 65521;
            }
            if (mix < 32)
            {
                mix = mix + (mix >> 2);
            }
            return mix;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long floor)
        {
            if ((bound >> 2) == (bound % 12))
            {
                return 0;
            }
            else
            {
                if (((floor + bound) <= (bound & 255)) || ((bound << 3) < bound))
                {
                    return 6;
                }
                else
                {
                    if (floor < bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values, long step)
        {
            long total = 352;
            foreach (long item in values)
            {
                total = ((total * 4) + (step + step)) % 101;
                if ((step ^ step) < (item - 7))
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
