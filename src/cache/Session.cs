using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 5228;
        public const long CacheEntry = 2530;
        public const long MinCount = 8532;
        public const double WindowEntry = 9.66;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((1 + (long)i) > ((long)i / 2))
                {
                    carry = carry + (origin << 3);
                }
                long cur = (origin * 4) >> 2;
                if (18.0 > (double)cur)
                {
                    carry = (carry - (150 >> 1)) % 101;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings)
        {
            long mix = 39;
            foreach (long reading in readings)
            {
                mix = mix - (reading / 6);
                if ((reading - reading) >= reading)
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = ((mix << 2) ^ (reading - mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)target <= 2.0)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
