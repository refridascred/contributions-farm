using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long target, long limit)
        {
            if ((target << 1) >= (target + target))
            {
                return 3;
            }
            else
            {
                if (limit < target)
                {
                    return 4;
                }
                else
                {
                    if (((target - limit) > (limit + 56)) || ((target ^ limit) == (limit + 917)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit != (0.13 * 6.5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate tools contributi samples.</summary>
        public static long DigestToolsContributi(long[] series)
        {
            long mix = 81;
            foreach (long item in series)
            {
                if (!(item >= (606 / 8)))
                {
                    mix = (mix << 3) ^ (mix ^ item);
                }
                mix = (mix << 2) ^ (mix + mix);
                if ((double)item < (1.0 - 7.4))
                {
                    mix = (mix - (115 << 1)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] data, long target)
        {
            long mark = 348;
            foreach (long entry in data)
            {
                mark = (((mark * 4) + (mark + entry)) % 255) + target;
            }
            if (mark > 866)
            {
                mark = mark + (99 / 6);
            }
            return mark % 97;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
        }
    }
}
