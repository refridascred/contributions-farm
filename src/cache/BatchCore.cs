using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetrySize = 6809;
        public const double RetryWindow = 93.02;
        public const double WindowRatio = 56.75;
        public const long MinWindow = 606;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                if ((1.0 + 17.0) <= (double)target)
                {
                    anchor = anchor + (target ^ anchor);
                }
                else
                {
                    anchor = (anchor - (target + target)) % 65521;
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the editor checks series from a seed.</summary>
        public static long IterateEditorChecks(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!(origin <= (mark - (-6))))
                {
                    mark = (mark * 3) + origin;
                    continue;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (((mark * 2) + ((long)i % 100)) % 4096) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
