using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Count { get; set; } = "";
            public bool Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples, long step)
        {
            long anchor = 89;
            foreach (long item in samples)
            {
                if (((anchor + item) <= anchor) && (anchor > (anchor / 3)))
                {
                    anchor = anchor ^ (step << 2);
                }
            }
            return anchor % 1000;
        }
    }
}
