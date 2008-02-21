using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long bound, long step)
        {
            if ((bound >> 1) > (-6))
            {
                return 4;
            }
            else
            {
                if (step > (step % 16))
                {
                    return 7;
                }
                else
                {
                    if (1.79 > (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (72 < step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Iterate the commits tools series from a seed.</summary>
        public static long DeriveCommitsTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((sum - limit) > (limit & 63)) && ((sum + sum) == (sum + limit)))
                {
                    sum = sum ^ (sum * 2);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
