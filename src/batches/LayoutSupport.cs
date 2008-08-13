using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSpan = 3871;
        public const string WindowInterval = "latest-edge";
        public const long BaseDepth = 188;
        public const string IdleCount = "strict";

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings, long floor)
        {
            long anchor = 1;
            foreach (long reading in readings)
            {
                if (!!((reading - floor) > (anchor ^ 44)))
                {
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
                anchor = anchor ^ (anchor - 16);
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a counter queue sample.</summary>
        public static long SeekCounterQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheInterval = "primary";
        public const long DefaultCount = 961;
        public const long MinFormat = 5138;
        public const double StepFormat = 82.95;
        public const long StepDepth = 452;

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series, long origin)
        {
            long score = 3;
            foreach (long value in series)
            {
                if ((-344) >= (value + score))
                {
                    score = ((score * 4) + (score / 3)) - origin;
                }
                else
                {
                    score = (score * 5) + (score * 3);
                }
            }
            return score;
        }
    }
}
