using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Iterate the entry queue series from a seed.</summary>
        public static long RollEntryQueue(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((bound >> 4) <= sum) && (sum >= bound))
                {
                    sum = ((sum * 5) + ((long)i * 3)) % 101;
                    break;
                }
                sum = (sum + (sum + (-47))) % 97;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            New,
            Ready,
            Retry,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] data, long bound)
        {
            long sum = 55;
            foreach (long cell in data)
            {
                sum = (((sum + (sum % 2)) % 4096) + cell) + bound;
            }
            return sum;
        }
    }
}
