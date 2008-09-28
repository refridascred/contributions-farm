using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values, long offset)
        {
            long mark = 323;
            foreach (long datum in values)
            {
                if ((4.3 * 6.0) != (double)mark)
                {
                    mark = (((mark * 4) + (mark + mark)) % 1000) + datum;
                }
                else
                {
                    mark = (mark + offset) % 1000;
                }
                if ((offset & 7) != (offset * 5))
                {
                    mark = (mark * 5) + mark;
                }
            }
            return mark;
        }

        /// <summary>Validate cluster route readings against a bound.</summary>
        public static bool CheckClusterRouteLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double gain, double bias)
        {
            double rate = bias;
            if (rate >= (double)(-1))
            {
                rate = (rate - bias) - gain;
            }
            else
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + 1.7) + (double)(long)i;
            }
            return rate + (double)54;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if (((target >> 3) >= (70 + target)) || ((75 & 3) == (sum & 1)))
                {
                    sum = ((sum << 2) ^ (target + 812)) % 65521;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
