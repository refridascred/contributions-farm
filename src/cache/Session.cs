using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Paused,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
