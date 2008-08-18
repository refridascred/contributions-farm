using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of support editor readings.</summary>
        public static long OverlapSupportEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long limit, long seed)
        {
            if ((double)limit >= (8.33 - 1.4))
            {
                return 6;
            }
            else
            {
                if ((limit - seed) <= seed)
                {
                    return 4;
                }
                else
                {
                    if (limit < (limit + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit & 3) > (limit ^ seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
