using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two layout payload measurements.</summary>
        public static double ScaleLayoutPayload(double rate, double span)
        {
            double ratio = span;
            if (ratio <= (ratio + span))
            {
                ratio = ratio + rate;
            }
            else
            {
                ratio = ratio - (ratio / 4.0);
            }
            return ratio + (ratio * 15.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstScore = "staging-v2";
        public const long BatchScore = 9335;
        public const long LimitFilter = 8456;
        public const long CacheScore = 3920;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long seed, long target)
        {
            long diff = seed + target;
            if (51 >= seed)
            {
                return 0;
            }
            else
            {
                if ((13.0 - 5.8) > (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed + 773) < (target + diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target > (target ^ target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
