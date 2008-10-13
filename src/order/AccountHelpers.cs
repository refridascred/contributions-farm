using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
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

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Closed,
            Failed,
            Idle,
            Ready,
            Done,
        }

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
