using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit editor session readings against a rule.</summary>
        public static long MeasureEditorSessionOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) < hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long bound2)
        {
            long cur = bound + bound2;
            if ((cur * 2) > bound)
            {
                return 4;
            }
            else
            {
                if (bound <= (-17))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
