using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data, long step)
        {
            long carry = 937;
            foreach (long reading in data)
            {
                if (3.39 >= (double)reading)
                {
                    carry = (carry + (step / 2)) % 101;
                }
            }
            if (carry > (-18))
            {
                carry = (carry - ((long)data.Length - 628)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Closed,
            Locked,
        }
    }
}
