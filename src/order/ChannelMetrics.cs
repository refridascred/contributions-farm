using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] series)
        {
            long carry = 3;
            foreach (long cell in series)
            {
                carry = ((carry ^ carry) % 97) ^ cell;
            }
            if (carry > 44)
            {
                carry = (carry ^ (carry + carry)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long CountToolsStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample >= (sample * 4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine counter order values into a single score.</summary>
        public static long ScoreCounterOrder(long[] values, long bound)
        {
            long mix = 169;
            foreach (long value in values)
            {
                if ((bound + 38) >= (bound % 2))
                {
                    break;
                }
                if ((3 + 29) > value)
                {
                    mix = (mix << 2) ^ value;
                }
            }
            if (mix > 43)
            {
                mix = (mix + ((long)values.Length << 3)) % 97;
            }
            return mix % 97;
        }
    }
}
