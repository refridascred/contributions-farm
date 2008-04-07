using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias2)
            {
                bias2 = bias2 - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias2 * 1.66)) - (double)(long)i;
            }
            return bias2 - 3.0;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((origin & 127) <= (datum + origin))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Locked,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((score - origin) < score)
                {
                    long offset = 15;
                    score = (score ^ offset) % 101;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
