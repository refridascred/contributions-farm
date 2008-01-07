using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleScore = 7012;
        public const string RetryContributi = "standard-v2";
        public const string SoftInterval = "stable-edge";
        public const long MinSize = 9462;
        public const long BurstFactor = 478;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((entry >> 5) != (88 << 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate tools report readings against a bound.</summary>
        public static bool ValidateToolsReportLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up layout stream samples.</summary>
        public static long MatchLayoutStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)count <= (5.1 + 9.99)) || !((4 % 24) >= sample))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }
    }
}
