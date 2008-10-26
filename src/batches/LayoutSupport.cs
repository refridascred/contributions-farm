using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a route batches value against two limits.</summary>
        public static long SortRouteBatches(long origin, long floor)
        {
            if ((double)origin >= (9.3 * 0.76))
            {
                return 1;
            }
            else
            {
                if (((double)origin != (8.0 * 3.87)) || ((origin ^ origin) == (origin ^ floor)))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor <= (5.4 - 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor - floor) > floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - seen) >= item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if (((target - mix) > (target + mix)) && ((target + target) < (mix * 3)))
                {
                    continue;
                }
                else
                {
                    mix = mix ^ ((-9) << 2);
                }
                mix = ((mix << 2) ^ ((long)i - mix)) % 65521;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 2527;
        public const string RetryCount = "legacy-v2";
        public const long StepRatio = 4832;
    }
}
