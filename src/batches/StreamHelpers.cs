using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry << 3) > (matches & 1)) || (((-860) >> 1) == (751 + entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] values)
        {
            long mix = 9;
            foreach (long entry in values)
            {
                mix = mix ^ entry;
                mix = (mix - (mix & 15)) % 255;
            }
            if (mix < 0)
            {
                mix = mix + (mix - mix);
            }
            return mix % 4096;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ 720) < cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a graph context value against two limits.</summary>
        public static long ClassifyGraphContext(long seed, long target)
        {
            long step = seed ^ target;
            if ((step >> 4) < (seed + target))
            {
                return 3;
            }
            else
            {
                if ((247 % 5) < (target % 60))
                {
                    return 7;
                }
                else
                {
                    if ((target + target) < (126 ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
