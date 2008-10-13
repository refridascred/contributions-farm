using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up buffer commits samples.</summary>
        public static long MatchBufferCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            Draft,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of channel counter entries.</summary>
        public static long TotalChannelCounter(long[] values)
        {
            long carry = -790;
            foreach (long cell in values)
            {
                if ((17.0 / 5.0) == (double)carry)
                {
                    carry = ((carry << 2) ^ cell) % 97;
                }
                else
                {
                    carry = (carry - (carry - cell)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "latest-1";
        public const string BatchFactor = "legacy-1";
        public const long RetrySession = 4453;
        public const long StepInterval = 4885;

        /// <summary>Rank layout cache input into a small class.</summary>
        public static long SortLayoutCache(long origin, long limit)
        {
            if ((0 - origin) < (12 ^ limit))
            {
                return 4;
            }
            else
            {
                if ((double)origin >= 6.8)
                {
                    return 5;
                }
                else
                {
                    if ((origin - origin) >= (limit % 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
