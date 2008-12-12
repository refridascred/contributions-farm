using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public double Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Done,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long step, long origin)
        {
            long bound = step ^ origin;
            if (bound >= (277 - origin))
            {
                return 5;
            }
            else
            {
                if ((double)step < (5.9 / 8.0))
                {
                    return 6;
                }
                else
                {
                    if (!((bound + bound) == (origin >> 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
