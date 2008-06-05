using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((5.9 / 4.0) >= (double)limit)
                {
                    total = ((total * 4) + (limit * 5)) % 4096;
                    continue;
                }
                if ((double)(long)i <= (double)(-558))
                {
                    total = ((total << 2) ^ total) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 7402;
        public const long LimitSpan = 6141;
        public const long StepSchema = 8548;
        public const long DefaultFactor = 2258;
        public const string IdleSchema = "alpha-1";

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long bound, long floor)
        {
            long bound2 = bound + floor;
            if ((bound % 60) <= (42 * 5))
            {
                return 7;
            }
            else
            {
                if ((bound2 <= (bound + bound)) || ((1.41 + 9.64) >= (double)bound2))
                {
                    return 5;
                }
                else
                {
                    if (bound < (99 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + bound2) < bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
