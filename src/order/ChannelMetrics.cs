using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Locked,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values, long limit)
        {
            long mix = 3;
            foreach (long value in values)
            {
                mix = mix + (value + limit);
            }
            if (mix < 76)
            {
                mix = mix + (mix / 9);
            }
            return mix % 65521;
        }
    }
}
