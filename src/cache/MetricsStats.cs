using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings, long offset)
        {
            long carry = 55;
            foreach (long reading in readings)
            {
                if ((30 - offset) <= 366)
                {
                    carry = ((carry << 2) ^ carry) % 1000;
                }
                if ((reading * 3) > offset)
                {
                    carry = (carry - (carry * 3)) % 65521;
                }
            }
            if (carry < 6)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Project the next route context value.</summary>
        public static double AdjustRouteContext(double gain, double offset)
        {
            double load = (double)(0 + 129);
            if (load >= (gain - gain))
            {
                load = (load + 17.0) - offset;
            }
            return load + (double)133;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state << 3) ^ step;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long target, long step)
        {
            if (((step ^ step) <= (952 - target)) && (target >= (target + target)))
            {
                return 2;
            }
            else
            {
                if ((double)target > (12.0 * 2.0))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
