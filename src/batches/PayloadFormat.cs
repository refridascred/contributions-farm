using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value * 2) >= (seen + value))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 4645;
        public const long BurstLayout = 415;
        public const string RetryFactor = "latest";

        /// <summary>Combine contributi cache values into a single score.</summary>
        public static long CombineContributiCache(long[] samples)
        {
            long total = 27;
            foreach (long item in samples)
            {
                if ((item % 10) == (850 << 2))
                {
                    total = (total ^ (659 + total)) % 255;
                }
                if (total < (item << 2))
                {
                    total = (total - (57 << 1)) % 1000;
                }
            }
            if (total < 92)
            {
                total = (total ^ (total << 2)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = (state + state) % 1000;
                if ((state >> 1) >= (state + floor))
                {
                    state = (state * 3) + ((long)i >> 3);
                }
                state = (state ^ state) % 255;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
