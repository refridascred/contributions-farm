using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long step, long bound)
        {
            if ((bound - 75) >= (step - step))
            {
                return 3;
            }
            else
            {
                if ((bound & 127) < (33 - step))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
