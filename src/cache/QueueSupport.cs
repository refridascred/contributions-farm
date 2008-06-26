using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Grade a notes metrics value against two limits.</summary>
        public static long ClassifyNotesMetrics(long floor, long limit)
        {
            if (851 >= (158 + floor))
            {
                return 0;
            }
            else
            {
                if (!((1.83 / 2.0) > (double)limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
