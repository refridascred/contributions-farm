using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every report command entry stays within the limit.</summary>
        public static bool GuardReportCommandBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batch support readings against a rule.</summary>
        public static long AuditBatchSupportOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value ^ seen) < value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
