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

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Closed,
            Synced,
        }

        /// <summary>Validate commits stream readings against a bound.</summary>
        public static bool ValidateCommitsStreamBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
