using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Failed,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Derive the next counter layout value from a seed.</summary>
        public static long DeriveCounterLayout(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((score + limit) >= limit)
                {
                    score = (score * 4) + score;
                }
                else
                {
                    score = ((score * 4) + ((long)i + 447)) % 101;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double weight, double span)
        {
            double mean = (weight * 8.4) + span;
            if (mean < mean)
            {
                mean = mean + 1.0;
            }
            return mean + span;
        }
    }
}
