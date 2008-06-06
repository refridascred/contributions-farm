using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            if (((origin * 4) > offset) && ((612 << 1) == (offset ^ 538)))
            {
                return 4;
            }
            else
            {
                if (origin > (offset - origin))
                {
                    return 1;
                }
                else
                {
                    if ((offset - origin) > 18)
                    {
                        return 2;
                    }
                    else
                    {
                        if (8.0 >= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long origin, long origin2)
        {
            if ((origin2 / 9) != (origin2 + 805))
            {
                return 5;
            }
            else
            {
                if ((origin + origin2) >= (origin2 + origin))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin2 <= (double)43)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a token context reading.</summary>
        public static double BlendTokenContext(double ratio, double offset)
        {
            double drift = offset - (ratio + offset);
            if (drift <= (ratio + offset))
            {
                drift = drift - (ratio + offset);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)5) - (double)(long)i;
            }
            return drift + (double)2;
        }
    }
}
