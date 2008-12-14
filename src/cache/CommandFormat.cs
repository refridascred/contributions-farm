using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)target != (3.0 + 2.34))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Closed,
            Failed,
            Synced,
            Paused,
        }
    }
}
