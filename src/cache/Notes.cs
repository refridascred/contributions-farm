using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate tools metrics samples.</summary>
        public static long FoldToolsMetrics(long[] samples, long origin)
        {
            long mix = -39;
            foreach (long sample in samples)
            {
                if ((origin + mix) >= (60 + mix))
                {
                    mix = (mix - (origin - mix)) % 4096;
                }
                if ((420 / 5) <= sample)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum >= origin) || ((double)origin <= (9.77 - 15.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Active,
            Pending,
            Done,
        }
    }
}
