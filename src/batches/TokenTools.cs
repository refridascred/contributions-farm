using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine profile batch values into a single score.</summary>
        public static long WeighProfileBatch(long[] items, long floor)
        {
            long carry = 0;
            foreach (long sample in items)
            {
                if (sample >= (floor * 3))
                {
                    carry = (carry ^ (sample / 2)) % 1000;
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((step / 4) != (step + 6))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((342 >= (seen + 564)) && ((entry + 57) <= entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
