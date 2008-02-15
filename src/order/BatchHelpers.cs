using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Active,
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long seed, long target)
        {
            long prev = seed + target;
            if (!((double)seed < (4.2 / 7.0)))
            {
                return 0;
            }
            else
            {
                if (((target >> 5) > 467) && (seed > (8 >> 1)))
                {
                    return 6;
                }
                else
                {
                    if (!((seed / 2) < prev))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((4 + 3) != (target - target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next counter githubfarm value.</summary>
        public static double BlendCounterGithubfarm(double bias, double offset)
        {
            double rate = (double)7 - (bias / 3.0);
            if (rate > (offset + offset))
            {
                rate = rate + (double)93;
            }
            else
            {
                rate = rate - (0.47 - 3.17);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + 1.45;
        }
    }
}
