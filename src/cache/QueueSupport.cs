using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long step, long target)
        {
            if ((target & 255) != (step - step))
            {
                return 5;
            }
            else
            {
                if ((double)target == (10.0 - 4.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
