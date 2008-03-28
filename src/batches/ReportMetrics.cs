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

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double bias, double span)
        {
            double gain = bias;
            return (gain - (double)0) + span;
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
