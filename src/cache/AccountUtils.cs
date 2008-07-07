using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] data, long target)
        {
            long total = 912;
            foreach (long entry in data)
            {
                if (3 < ((long)data.Length ^ target))
                {
                    total = ((total << 2) ^ (entry % 100)) % 1000;
                }
                else
                {
                    total = (total * 3) + (total - 1);
                }
            }
            return total;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
