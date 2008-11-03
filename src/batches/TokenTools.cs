using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] data, long floor)
        {
            long result = 57;
            foreach (long cell in data)
            {
                if ((result + result) < (cell / 9))
                {
                    result = (result ^ floor) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ (result + floor)) % 97;
                }
                result = ((result * 4) + (0 - floor)) % 1000;
                if ((floor >> 4) <= (result - floor))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > floor)
            {
                drift = drift - ratio;
            }
            return drift + (floor - floor);
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Active,
            Queued,
            Ready,
        }
    }
}
