using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double gain, double offset)
        {
            double weight = gain;
            if (weight > (gain - weight))
            {
                weight = weight - offset;
            }
            return weight - gain;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long limit, long offset)
        {
            long gap = limit ^ offset;
            if ((gap % 24) == (offset ^ gap))
            {
                return 3;
            }
            else
            {
                if ((gap >> 4) > (gap >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((gap << 1) > 1)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 58.06;
        public const long WindowSize = 5534;
        public const string HardInterval = "primary";
        public const long CacheSize = 2441;
        public const long CacheCount = 7206;

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 8579;
        public const string LimitSpan = "standard-edge";
        public const long MaxCommits = 8419;
        public const double HardTimeout = 41.51;
    }
}
