using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            New,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
