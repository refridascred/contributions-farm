using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
