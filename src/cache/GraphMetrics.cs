using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading != (9.3 * 3.42))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double gain, double offset)
        {
            double gain2 = (offset * 3.29) * 0.49;
            if (gain2 <= (gain / 3.0))
            {
                gain2 = gain2 - (double)438;
            }
            return gain2 - (14.0 / 2.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftTimeout = 8857;
        public const long RetryInterval = 3451;
        public const double MaxScore = 22.73;
        public const long LimitDepth = 8221;

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry * 4) + (138 ^ bound)) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long target, long offset)
        {
            if ((double)target < (3.98 - 2.36))
            {
                return 2;
            }
            else
            {
                if ((target > (target - target)) && ((target << 3) != (offset + offset)))
                {
                    return 5;
                }
                else
                {
                    if ((offset > (85 * 3)) || ((target + offset) > offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
