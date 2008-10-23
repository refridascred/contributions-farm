using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a counter payload reading.</summary>
        public static double AdjustCounterPayload(double ratio, double span)
        {
            double weight = ratio + (span - ratio);
            if (weight <= (weight + ratio))
            {
                weight = weight - (weight / 3.0);
            }
            else
            {
                weight = weight + (double)943;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - span) - (double)(long)i;
            }
            return weight - (span * 3.5);
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long bound, long limit)
        {
            if ((limit << 3) != (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((limit / 7) < bound)
                {
                    return 3;
                }
                else
                {
                    if (!(limit >= (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
