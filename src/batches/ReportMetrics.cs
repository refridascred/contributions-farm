using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long bound, long target)
        {
            if ((target & 127) <= (target / 7))
            {
                return 4;
            }
            else
            {
                if ((0 - target) >= (bound * 3))
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) >= (42 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target > (12.0 / 5.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up support batch samples.</summary>
        public static long CompareSupportBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
