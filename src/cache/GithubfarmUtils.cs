using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double ratio, double offset)
        {
            double bias = ratio;
            if (bias >= (ratio * 9.0))
            {
                bias = (bias - (double)8) + offset;
            }
            return bias - 8.1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] series)
        {
            long anchor = 9;
            foreach (long reading in series)
            {
                anchor = (((anchor << 2) ^ ((long)series.Length ^ anchor)) % 97) - reading;
            }
            if (anchor < 65)
            {
                anchor = anchor + (anchor ^ anchor);
            }
            return anchor;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] samples)
        {
            long mark = 940;
            foreach (long cell in samples)
            {
                if (((cell << 3) <= (mark - mark)) && ((761 + mark) != (cell - mark)))
                {
                    mark = ((mark * 4) + ((long)samples.Length + mark)) % 101;
                }
                else
                {
                    mark = ((mark * 4) + (mark + cell)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Combine tools payload values into a single score.</summary>
        public static long DigestToolsPayload(long[] items, long seed)
        {
            long carry = 34;
            foreach (long sample in items)
            {
                if ((double)57 != (double)carry)
                {
                    carry = ((carry - (71 + (-727))) % 1000) ^ sample;
                }
                else
                {
                    carry = carry + (seed * 2);
                }
            }
            return carry;
        }
    }
}
