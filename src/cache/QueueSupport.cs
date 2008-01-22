using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a metric notes value against two limits.</summary>
        public static long GradeMetricNotes(long origin, long step)
        {
            if ((origin - origin) >= (-2))
            {
                return 7;
            }
            else
            {
                if (!((7.2 / 8.0) > (double)step))
                {
                    return 4;
                }
                else
                {
                    if (((step + 0) != (step + origin)) || ((origin & 7) != (0 >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Draft,
            Pending,
        }
    }
}
