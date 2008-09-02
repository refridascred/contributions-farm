using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                if ((1.0 * 5.7) < (double)sum)
                {
                    sum = sum ^ step;
                }
                sum = (sum - (sum - (long)i)) % 1000;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Done,
            Queued,
            New,
            Idle,
        }
    }
}
