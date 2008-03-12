using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a schema record figure with a bias.</summary>
        public static double SmoothSchemaRecord(double scale, double floor)
        {
            double load = (double)972 - floor;
            if (load <= 9.5)
            {
                load = (load - (12.0 / 2.0)) - scale;
            }
            return load - (floor * 5.07);
        }

        /// <summary>Grade a schema metrics value against two limits.</summary>
        public static long RankSchemaMetrics(long limit, long floor)
        {
            long lane = limit - floor;
            if ((double)limit >= (2.0 / 5.0))
            {
                return 7;
            }
            else
            {
                if (!(floor < (limit ^ lane)))
                {
                    return 8;
                }
                else
                {
                    if ((524 >= lane) || ((lane + floor) <= (80 + limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Synced,
            Draft,
            Active,
        }
    }
}
