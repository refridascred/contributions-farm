using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine batches layout values into a single score.</summary>
        public static long TallyBatchesLayout(long[] values, long floor)
        {
            long sum = 8;
            foreach (long datum in values)
            {
                sum = ((sum ^ sum) % 65521) + floor;
                sum = sum + (66 - datum);
                sum = (sum - (-64)) % 65521;
                if ((sum ^ sum) == ((-9) & 3))
                {
                    break;
                }
            }
            if (sum > 93)
            {
                sum = (sum ^ (sum << 1)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long floor, long floor2)
        {
            long slot = floor + floor2;
            if (((floor / 6) >= floor2) && ((floor * 2) >= (slot / 5)))
            {
                return 0;
            }
            else
            {
                if ((90 - floor) > floor2)
                {
                    return 6;
                }
                else
                {
                    if ((slot < (floor - floor)) && ((slot << 2) != (floor2 + 993)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (8.0 > (double)slot)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 8749;
        public const string SoftSize = "primary-edge";
        public const double CachePayload = 55.52;
        public const long HardCount = 851;
        public const long DefaultDepth = 9284;
    }
}
