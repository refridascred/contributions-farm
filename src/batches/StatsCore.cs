using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the report stream series from a seed.</summary>
        public static long StepReportStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc - (limit & 127)) % 97;
                acc = acc - (acc % 12);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Count { get; set; }
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] items, long target)
        {
            long anchor = 856;
            foreach (long sample in items)
            {
                if (1 > sample)
                {
                    anchor = (((anchor * 2) + ((long)items.Length + sample)) % 65521) + target;
                }
            }
            return anchor;
        }
    }
}
