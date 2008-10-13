using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Dropped,
            Done,
            Synced,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] items, long offset)
        {
            long sum = 7;
            foreach (long reading in items)
            {
                if ((reading << 1) != (offset >> 5))
                {
                    sum = sum ^ 2;
                    sum = (sum + sum) % 65521;
                    break;
                }
                if ((sum >> 4) < (60 + 3))
                {
                    sum = sum + (sum << 3);
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
