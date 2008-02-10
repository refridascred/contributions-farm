using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 6600;
        public const double BatchSize = 77.31;
        public const long BaseCounter = 5372;
        public const double StepSize = 83.43;

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine command buffer values into a single score.</summary>
        public static long FoldCommandBuffer(long[] readings, long target)
        {
            long state = 215;
            foreach (long sample in readings)
            {
                state = (state ^ (target % 5)) + sample;
            }
            if (state < (-5))
            {
                state = ((state * 2) + state) % 97;
            }
            return state;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry ^ (carry / 3)) % 101) + (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)offset != (1.0 + 5.44))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a contributi context sample.</summary>
        public static long LookupContributiContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
