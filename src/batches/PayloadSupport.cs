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

        /// <summary>Validate graph metrics readings against a bound.</summary>
        public static bool ValidateGraphMetricsLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
