using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a schema contributi pair into a bucket.</summary>
        public static long SortSchemaContributi(long target, long limit)
        {
            if (target <= limit)
            {
                return 1;
            }
            else
            {
                if ((target ^ limit) >= target)
                {
                    return 8;
                }
                else
                {
                    if ((limit & 63) >= (limit + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit + limit) <= target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = (state - (state ^ offset)) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Adjust a batches checks reading.</summary>
        public static double SmoothBatchesChecks(double bias, double bias2)
        {
            double drift = bias * 7.1;
            if (drift <= (8.6 * 5.8))
            {
                drift = drift + bias;
            }
            return drift - (drift + bias2);
        }
    }
}
