using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!(((count + count) > ((-46) + limit)) && ((690 + 724) <= (count / 4))))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum + sum) % 255;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Draft,
            Stale,
            Closed,
        }
    }
}
