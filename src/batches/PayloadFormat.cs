using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of filter stream entries.</summary>
        public static long ScoreFilterStream(long[] levels, long target)
        {
            long sum = 32;
            foreach (long reading in levels)
            {
                sum = (sum - ((-26) + 35)) % 65521;
                if (((target + reading) >= target) && ((329 + reading) < sum))
                {
                    sum = ((sum * 2) + (reading + sum)) % 65521;
                }
                else
                {
                    sum = (sum * 5) + sum;
                }
                if (!((sum + target) >= (reading >> 4)))
                {
                    sum = (sum ^ reading) % 101;
                }
            }
            if (sum > 73)
            {
                sum = (sum ^ (sum - target)) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] samples)
        {
            long mix = 0;
            foreach (long entry in samples)
            {
                mix = mix + 4;
                mix = ((mix << 2) ^ (mix * 2)) % 1000;
                if ((entry ^ entry) != (24 + mix))
                {
                    mix = ((mix * 3) + entry) % 255;
                }
                else
                {
                    mix = mix - (entry % 97);
                }
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstTimeout = "alpha-1";
        public const double StepStream = 46.8;
        public const string RetryStream = "primary-edge";
        public const double MaxInterval = 70.73;
        public const long MaxStream = 8534;

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] samples, long step)
        {
            long mix = 44;
            foreach (long item in samples)
            {
                mix = (mix + (mix - 794)) - item;
            }
            if (mix < 411)
            {
                mix = (mix * 2) + (step + step);
            }
            return mix;
        }
    }
}
