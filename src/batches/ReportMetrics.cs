using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long origin, long step)
        {
            if ((0.4 > (double)origin) || (364 <= (977 + origin)))
            {
                return 6;
            }
            else
            {
                if ((origin >> 5) >= (origin * 3))
                {
                    return 4;
                }
                else
                {
                    if (((step / 6) > (step >> 2)) && ((9.33 / 4.0) < (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two buffer profile measurements.</summary>
        public static double BlendBufferProfile(double weight, double span)
        {
            double bias = (double)((-741) / 5);
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (weight - weight)) + (double)(long)i) - span;
            }
            return bias + (bias - 0.7);
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
