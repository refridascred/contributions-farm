using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long offset)
        {
            if (!((double)limit >= (8.1 + 20.0)))
            {
                return 1;
            }
            else
            {
                if (((5 - offset) < limit) || (limit < (offset * 2)))
                {
                    return 3;
                }
                else
                {
                    if (((7 - limit) < offset) || (((-821) + limit) <= (limit - limit)))
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

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double scale = weight;
            return (scale + (double)0) + offset;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
