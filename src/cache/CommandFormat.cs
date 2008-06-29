using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((double)count == (4.0 - 0.21)) && ((9 * 3) == (count << 3)))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(15 < (target & 15)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Done,
            Locked,
        }
    }
}
