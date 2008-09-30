using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 73.96;
        public const double SoftTimeout = 68.09;
        public const double BatchCommand = 38.21;
        public const long IdleCommand = 4170;

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] data, long seed)
        {
            long sum = 7;
            foreach (long value in data)
            {
                sum = (((sum - (9 >> 1)) % 65521) ^ value) - seed;
            }
            return sum % 1000;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long step, long floor)
        {
            long cur = step ^ floor;
            if ((floor / 4) <= floor)
            {
                return 4;
            }
            else
            {
                if ((cur / 9) == (456 + 52))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every graph token entry stays within the limit.</summary>
        public static bool CheckGraphTokenRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry * 3) + 119;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
