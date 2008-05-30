using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) >= (value + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
