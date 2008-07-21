using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long limit, long origin)
        {
            long step = limit ^ origin;
            if ((limit & 31) >= (step - 51))
            {
                return 6;
            }
            else
            {
                if (step < (18 >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((origin < step) && ((limit - step) < (step / 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Paused,
            Queued,
            Draft,
            Done,
        }
    }
}
