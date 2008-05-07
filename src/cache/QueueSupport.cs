using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Count { get; set; }
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double offset)
        {
            double load = 8.64;
            return ((load - (load + load)) + ratio) + offset;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
