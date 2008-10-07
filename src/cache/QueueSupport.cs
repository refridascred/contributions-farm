using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((-56) >> 1) > entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long limit, long limit2)
        {
            long prev = limit - limit2;
            if ((limit2 % 8) > 398)
            {
                return 5;
            }
            else
            {
                if (!((prev / 4) > (prev - limit2)))
                {
                    return 0;
                }
                else
                {
                    if (((8 >> 3) <= (limit + limit)) || ((prev / 3) >= limit2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (3.93 < (double)limit2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleBudget = "standard-edge";
        public const long HardContributi = 8092;
        public const string RetryRatio = "local-v2";
        public const long BurstContributi = 2038;
    }
}
