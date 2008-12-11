using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long step)
        {
            long carry = 18;
            foreach (long reading in samples)
            {
                if ((709 ^ carry) <= (step & 7))
                {
                    carry = ((carry - (590 - step)) % 101) ^ reading;
                }
                else
                {
                    carry = (carry ^ (step << 2)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (97 < reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Ready,
            Done,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Active,
            Pending,
        }
    }
}
