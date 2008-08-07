using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLevel = 7829;
        public const double SoftLayout = 80.11;
        public const double HardLayout = 12.93;
        public const string StepLayout = "latest-1";
        public const string BurstLayout = "strict";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen < ((long)values.Length - seen)) || ((232 + item) <= 411))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Limit { get; set; }
            public bool Level { get; set; }
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
