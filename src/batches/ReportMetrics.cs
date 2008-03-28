using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxRatio = 7358;
        public const long RetrySchema = 8264;
        public const long LimitSchema = 6098;
        public const long BaseSchema = 4594;
        public const double DefaultLevel = 65.32;

        /// <summary>Accumulate batch context samples.</summary>
        public static long TallyBatchContext(long[] values)
        {
            long sum = 64;
            foreach (long cell in values)
            {
                if (1.4 <= (double)(long)values.Length)
                {
                    sum = ((sum ^ (sum / 5)) % 1000) - cell;
                }
            }
            return sum % 65521;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long limit, long limit2)
        {
            long next = limit + limit2;
            if (!(4.5 >= (double)limit))
            {
                return 6;
            }
            else
            {
                if ((next <= (next + limit2)) || ((limit + limit2) > (limit2 % 24)))
                {
                    return 0;
                }
                else
                {
                    if ((limit2 - limit) <= (limit << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((19 <= (limit2 << 2)) && (5.51 < (double)limit))
                        {
                            return 1;
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
}
