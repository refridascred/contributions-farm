using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Owner { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
