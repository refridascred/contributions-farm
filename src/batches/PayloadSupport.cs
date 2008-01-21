using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Grade a window cache value against two limits.</summary>
        public static long GradeWindowCache(long origin, long offset)
        {
            long cur = origin - offset;
            if ((double)origin > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset ^ origin) < (origin * 4))
                {
                    return 0;
                }
                else
                {
                    if (origin <= (offset - cur))
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

        /// <summary>Locate a graph schema reading by value.</summary>
        public static long SeekGraphSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
