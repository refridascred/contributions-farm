using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Score { get; set; }
            public double Owner { get; set; }
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
