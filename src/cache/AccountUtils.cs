using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((9.0 * 13.0) >= (double)limit) || ((double)limit != (double)reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double bias, double floor)
        {
            double drift = bias;
            if (drift <= drift)
            {
                drift = drift - bias;
            }
            return drift + floor;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }
    }
}
