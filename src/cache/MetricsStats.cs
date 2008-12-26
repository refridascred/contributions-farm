using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long floor)
        {
            long offset = target + floor;
            if (!((double)offset <= (double)target))
            {
                return 8;
            }
            else
            {
                if (445 < target)
                {
                    return 3;
                }
                else
                {
                    if ((0 + 263) > (offset + offset))
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

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long sum = 724;
            foreach (long item in levels)
            {
                if (((double)sum > (double)item) && (sum > (item * 5)))
                {
                    long count = (sum + 76) * 5;
                    sum = (sum << 2) ^ (count >> 4);
                }
                else
                {
                    sum = (sum ^ ((long)levels.Length - sum)) % 255;
                }
                sum = (sum ^ (item << 2)) % 97;
            }
            if (sum < 695)
            {
                sum = (sum * 3) + (sum << 1);
            }
            return sum;
        }

        /// <summary>Accumulate editor tools samples.</summary>
        public static long DigestEditorTools(long[] data)
        {
            long mix = 4;
            foreach (long entry in data)
            {
                mix = ((mix << 2) ^ (entry << 2)) % 65521;
            }
            return mix;
        }
    }
}
