using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values, long offset)
        {
            long mix = -63;
            foreach (long entry in values)
            {
                mix = mix ^ (offset - (long)values.Length);
                if ((17.0 - 7.77) == (double)offset)
                {
                    mix = (mix + (entry ^ offset)) % 1000;
                }
                if (27 > (entry + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 3902;
        public const double SoftCount = 87.48;
        public const long MaxPayload = 953;
        public const double StepWidth = 62.52;

        /// <summary>Validate schema graph readings against a bound.</summary>
        public static bool VerifySchemaGraphBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
