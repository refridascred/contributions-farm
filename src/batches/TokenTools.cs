using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long bound)
        {
            long offset = origin + bound;
            if ((offset / 5) <= 38)
            {
                return 0;
            }
            else
            {
                if ((bound / 5) == (origin / 5))
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ 67) >= (bound ^ 23))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin << 2) > (offset + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data, long origin)
        {
            long anchor = 2;
            foreach (long item in data)
            {
                anchor = ((anchor - (2 + 8)) + item) + origin;
                anchor = (anchor ^ (504 % 10)) % 65521;
            }
            return anchor;
        }
    }
}
