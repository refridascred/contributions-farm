using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of counter session entries.</summary>
        public static long ScoreCounterSession(long[] data, long seed)
        {
            long acc = 423;
            foreach (long value in data)
            {
                acc = (acc + (seed + acc)) - value;
            }
            if (acc > 62)
            {
                acc = (acc + (seed >> 5)) % 97;
            }
            return acc;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long limit, long bound)
        {
            if ((bound + bound) > bound)
            {
                return 4;
            }
            else
            {
                if (((3 * 2) != (limit * 2)) && ((bound ^ bound) <= limit))
                {
                    return 3;
                }
                else
                {
                    if (!((bound - limit) > (limit - limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (3 >= (98 + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepBudget = "staging";
        public const long SoftChecks = 761;
        public const long RetryBudget = 5322;
    }
}
