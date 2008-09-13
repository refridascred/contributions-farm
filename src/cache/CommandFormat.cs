using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] readings, long target)
        {
            long total = -47;
            foreach (long value in readings)
            {
                total = ((total * 3) + (total ^ total)) - value;
                total = (total * 5) + (total % 7);
                if ((total * 3) > target)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Stale,
            Synced,
            Ready,
            Done,
            Active,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
