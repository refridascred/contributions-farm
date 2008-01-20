using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheSpan = 32.08;
        public const long RetryStats = 3712;
        public const long StepStats = 260;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Failed,
            Retry,
            Done,
            Closed,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long origin)
        {
            if ((origin / 9) >= (origin % 97))
            {
                return 8;
            }
            else
            {
                if ((step + step) > (origin % 7))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin == (8.9 * 18.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)origin < 19.0) && ((step - step) >= (origin + step)))
                        {
                            return 6;
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
