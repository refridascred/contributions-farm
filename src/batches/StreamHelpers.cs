using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 5097;
        public const double HardTools = 6.09;
        public const string MinRatio = "strict";

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Synced,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((8.6 * 5.3) < (double)cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long origin, long offset)
        {
            if ((double)origin > (19.0 * 5.0))
            {
                return 8;
            }
            else
            {
                if (((9.0 + 10.0) >= 9.0) || ((origin % 97) < (origin * 4)))
                {
                    return 2;
                }
                else
                {
                    if (!((origin / 5) <= origin))
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

        /// <summary>Audit record route readings against a rule.</summary>
        public static long TallyRecordRouteHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches + entry) == (entry + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
