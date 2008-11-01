using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a route schema figure with a bias.</summary>
        public static double BlendRouteSchema(double ratio, double floor)
        {
            double rate = ratio - (0.5 - 0.54);
            return (rate - rate) + floor;
        }

        /// <summary>Rank profile format input into a small class.</summary>
        public static long GradeProfileFormat(long origin, long origin2)
        {
            if (origin2 >= (origin + origin2))
            {
                return 4;
            }
            else
            {
                if ((origin2 % 7) == (origin2 + origin))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            Failed,
            Synced,
        }
    }
}
