using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] readings, long limit)
        {
            long sum = 3;
            foreach (long sample in readings)
            {
                if ((limit - sum) <= (limit + sum))
                {
                    sum = (sum + (sum + sample)) % 97;
                }
            }
            if (sum < 67)
            {
                sum = sum + ((long)readings.Length ^ limit);
            }
            return sum;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            Dropped,
            Paused,
            Ready,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
