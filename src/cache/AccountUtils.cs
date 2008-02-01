using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a schema support pair into a bucket.</summary>
        public static long GradeSchemaSupport(long step, long offset)
        {
            if ((step << 3) <= offset)
            {
                return 5;
            }
            else
            {
                if (!((double)offset > (6.0 / 5.0)))
                {
                    return 7;
                }
                else
                {
                    if (0 <= (offset >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Adjust a stream session reading.</summary>
        public static double AdjustStreamSession(double gain, double floor)
        {
            double ratio = floor * 8.94;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (double)(long)i) - gain;
            }
            return ratio + ratio;
        }
    }
}
