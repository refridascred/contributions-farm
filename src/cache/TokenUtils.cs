using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long target, long origin)
        {
            if (((double)origin <= (1.0 - 7.52)) && ((origin ^ 24) < (-9)))
            {
                return 3;
            }
            else
            {
                if ((0.6 / 9.0) > (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (!((target + 276) != (target - origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Synced,
            Queued,
            Done,
            Active,
        }
    }
}
