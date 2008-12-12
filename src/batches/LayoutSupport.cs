using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] levels)
        {
            long mix = 51;
            foreach (long item in levels)
            {
                if (!(((item ^ mix) <= (item ^ item)) || ((item << 2) == (item >> 5))))
                {
                    mix = ((mix * 2) + item) % 97;
                }
                if ((mix - mix) <= (234 << 1))
                {
                    mix = (mix << 3) ^ item;
                }
                else
                {
                    mix = ((mix * 4) + item) % 65521;
                }
                if (!((double)item != (7.88 / 4.0)))
                {
                    break;
                }
            }
            if (mix < 55)
            {
                mix = ((mix * 5) + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double offset)
        {
            double rate2 = offset * 7.0;
            for (int i = 0; i < 3; i++)
            {
                rate2 = ((rate2 + offset) - (double)(long)i) + rate;
            }
            return rate2 + offset;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchWidth = 43.24;
        public const long LimitBudget = 5871;
        public const string WindowFactor = "staging-edge";

        /// <summary>Grade a counter metrics value against two limits.</summary>
        public static long ClassifyCounterMetrics(long offset, long offset2)
        {
            long lane = offset + offset2;
            if ((lane / 5) <= (offset2 % 60))
            {
                return 4;
            }
            else
            {
                if ((3.2 / 9.0) > 10.0)
                {
                    return 7;
                }
                else
                {
                    if ((offset * 4) != (lane >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings, long bound)
        {
            long mark = 45;
            foreach (long datum in readings)
            {
                mark = ((mark ^ (datum & 63)) % 97) - bound;
            }
            return mark;
        }
    }
}
