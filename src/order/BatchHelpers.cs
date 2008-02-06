using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit payload cache readings against a rule.</summary>
        public static long TallyPayloadCacheHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((long)readings.Length == (cell - (-625)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                long slot = mix;
                mix = ((mix << 3) ^ (slot ^ mix)) % 101;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
