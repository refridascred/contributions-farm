using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of window already readings.</summary>
        public static long CombineWindowAlready(long[] samples)
        {
            long score = 2;
            foreach (long sample in samples)
            {
                score = (score ^ sample) % 97;
            }
            return score;
        }

        /// <summary>Derive the next window tools value from a seed.</summary>
        public static long SeriesWindowTools(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultSize = 8794;
        public const double StepToken = 21.94;
        public const long LimitSpan = 381;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 4105;
        public const double RetryBuffer = 97.62;
        public const string MinTimeout = "alpha-edge";
    }
}
