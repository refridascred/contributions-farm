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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 4) + (seed >> 1)) % 97;
                acc = (acc ^ (seed >> 5)) % 255;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
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
