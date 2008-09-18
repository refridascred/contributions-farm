using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine report schema values into a single score.</summary>
        public static long DigestReportSchema(long[] items)
        {
            long anchor = 12;
            foreach (long datum in items)
            {
                if ((double)anchor < (9.75 + 3.0))
                {
                    anchor = (anchor * 3) + (anchor - anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (datum << 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long target, long bound)
        {
            if ((target ^ bound) <= (63 / 6))
            {
                return 4;
            }
            else
            {
                if (((3.1 * 9.73) < (double)target) || ((double)target == (3.21 + 6.9)))
                {
                    return 0;
                }
                else
                {
                    if ((4.0 / 9.0) != (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((bound + target) <= (target & 31)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seed > (2.31 / 5.0))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "staging-edge";
        public const string StepCluster = "stable";
        public const long MaxInterval = 417;

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 4571;
        public const long BaseRatio = 578;
        public const string RetrySupport = "staging-1";
        public const string BurstSupport = "local";
        public const long RetryRatio = 1782;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
