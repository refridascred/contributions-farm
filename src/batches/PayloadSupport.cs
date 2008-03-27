using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Idle,
            Retry,
        }
    }
}
