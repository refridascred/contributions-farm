using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                if (!(((long)i + carry) == (step + step)))
                {
                    carry = (carry - (step - carry)) % 101;
                    continue;
                }
                if (((20.0 / 4.0) <= (double)carry) && ((carry + (long)i) > (carry ^ 533)))
                {
                    carry = (carry ^ (carry - step)) % 97;
                    carry = ((carry << 3) ^ (carry - (long)i)) % 1000;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
