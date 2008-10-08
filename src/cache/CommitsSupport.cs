using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxFactor = 95.24;
        public const long BurstFactor = 2763;
        public const string SoftContributi = "open-1";

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Ready,
            Done,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
