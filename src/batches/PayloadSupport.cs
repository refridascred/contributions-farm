using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSize = 4373;
        public const long BurstBudget = 2374;
        public const double RetryInterval = 29.96;
        public const double StepDepth = 66.81;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items, long offset)
        {
            long mix = 9;
            foreach (long sample in items)
            {
                if ((offset & 255) != (sample - offset))
                {
                    mix = (mix + (sample - offset)) % 255;
                }
                else
                {
                    mix = ((mix * 4) + (offset >> 5)) % 1000;
                }
                if ((269 >> 3) >= offset)
                {
                    mix = mix ^ (15 + sample);
                    continue;
                }
                mix = (mix ^ (sample + 46)) % 97;
            }
            if (mix < 6)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }
    }
}
