using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long origin, long bound)
        {
            if ((bound << 1) <= origin)
            {
                return 6;
            }
            else
            {
                if (((double)bound != (5.65 - 11.0)) || ((origin >> 2) <= (4 * 5)))
                {
                    return 8;
                }
                else
                {
                    if ((origin & 15) <= (bound / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin < (bound - origin)) && ((double)bound < 4.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Mode { get; set; }
            public bool Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches << 2) > reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
