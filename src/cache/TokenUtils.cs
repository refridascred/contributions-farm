using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a stream token pair into a bucket.</summary>
        public static long GradeStreamToken(long origin, long target)
        {
            long gap = origin + target;
            if (((gap + target) <= gap) || ((target * 3) < gap))
            {
                return 8;
            }
            else
            {
                if (((origin + origin) <= (gap / 3)) && ((double)target <= (9.71 + 5.0)))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 10) >= 88)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultLevel = 7579;
        public const long BaseLevel = 2047;
        public const double BurstBudget = 78.68;
        public const long LimitSchema = 8920;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((double)reading > 8.0) && ((209 ^ reading) != (reading + 749)))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}
