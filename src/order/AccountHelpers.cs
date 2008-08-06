using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell > 77)
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Adjust a stats farm reading.</summary>
        public static double ProjectStatsFarm(double bias, double floor)
        {
            double scale = 5.0;
            if (scale >= (7.19 * 1.93))
            {
                scale = (scale + (double)61) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - (scale / 7.0);
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)matches < (8.1 - 0.62))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Queued,
            Active,
            New,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftCount = 8851;
        public const string BaseLevel = "local-edge";
        public const string BatchLevel = "legacy-1";
        public const long DefaultSession = 350;
        public const double CacheSession = 20.51;
    }
}
