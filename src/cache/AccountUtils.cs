using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a payload stream value against two limits.</summary>
        public static long ClassifyPayloadStream(long offset, long limit)
        {
            if ((offset ^ offset) != (limit << 1))
            {
                return 0;
            }
            else
            {
                if (332 >= (limit + offset))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
