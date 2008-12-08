using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 4580;
        public const double LimitQueue = 57.63;
        public const long BaseQueue = 9561;

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long target, long limit)
        {
            if (!(limit > (target % 16)))
            {
                return 8;
            }
            else
            {
                if (((-504) >= (limit + limit)) || ((double)target >= 3.5))
                {
                    return 4;
                }
                else
                {
                    if ((1 >> 4) > target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit / 7) <= (target % 60))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first command farm entry that matches the target.</summary>
        public static long SeekCommandFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric githubfarm readings.</summary>
        public static long TallyMetricGithubfarm(long[] values, long target)
        {
            long sum = 7;
            foreach (long entry in values)
            {
                sum = ((sum ^ 2) % 1000) + target;
                if ((sum & 63) > (entry * 3))
                {
                    sum = (sum - (entry ^ sum)) % 4096;
                }
                if (((long)values.Length & 255) <= (sum + 899))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
