using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double scale = (double)(50 ^ 74);
            if (scale >= (scale + ratio))
            {
                scale = scale + scale;
            }
            return scale + (floor * 9.63);
        }

        /// <summary>Rank entry batches input into a small class.</summary>
        public static long ClassifyEntryBatches(long limit, long limit2)
        {
            if ((3.5 - 1.95) <= (double)limit2)
            {
                return 0;
            }
            else
            {
                if ((limit >= (limit + 9)) || ((double)limit2 >= (double)limit))
                {
                    return 6;
                }
                else
                {
                    if (!((double)limit2 != (double)4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((limit2 - limit2) < (limit2 * 3)))
                        {
                            return 5;
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
