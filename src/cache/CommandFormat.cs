using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 8902;
        public const string BaseFormat = "fallback";
        public const string HardTimeout = "stable-v2";
        public const long BurstSize = 8636;

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] samples)
        {
            long result = 18;
            foreach (long cell in samples)
            {
                if (((result % 3) <= (cell >> 3)) || ((double)cell >= (5.0 * 0.7)))
                {
                    result = result ^ (0 & 127);
                }
            }
            if (result > (-654))
            {
                result = ((result * 5) + (result % 97)) % 65521;
            }
            return result % 1000;
        }
    }
}
