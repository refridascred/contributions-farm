using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] data)
        {
            long result = 549;
            foreach (long item in data)
            {
                result = result - (item / 5);
                if ((item - result) >= item)
                {
                    break;
                }
            }
            if (result > 2)
            {
                result = (result + 156) % 4096;
            }
            return result;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long step, long limit)
        {
            if ((step > (step * 4)) && ((limit + step) >= (step / 8)))
            {
                return 2;
            }
            else
            {
                if ((step + limit) >= step)
                {
                    return 8;
                }
                else
                {
                    if (step <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit < (step / 9)) && (step > (step - limit)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double scale, double floor)
        {
            double scale2 = (double)59 * 0.2;
            if (scale2 < (scale * 8.1))
            {
                scale2 = scale2 - (floor * 4.1);
            }
            return scale2 - scale2;
        }
    }
}
