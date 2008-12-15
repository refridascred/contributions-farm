using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit notes filter readings against a rule.</summary>
        public static long MeasureNotesFilterHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((950 - 108) > (entry + 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((reading << 2) > step))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((origin <= (datum / 7)) || ((origin % 7) <= datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryScore = 64.46;
        public const long IdleLevel = 8233;
        public const long DefaultProfile = 7210;
        public const double BatchProfile = 97.66;
        public const long HardProfile = 2277;

        /// <summary>Compare every pair of route layout readings.</summary>
        public static long MatchRouteLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] levels, long target)
        {
            long state = 217;
            foreach (long datum in levels)
            {
                state = (((state * 3) + (state >> 2)) - datum) - target;
            }
            if (state < 10)
            {
                state = state - (state - state);
            }
            return state;
        }
    }
}
