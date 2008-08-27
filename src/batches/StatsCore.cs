using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                if (offset > (carry % 64))
                {
                    carry = (carry - (carry ^ carry)) % 65521;
                    carry = (carry - (offset << 1)) % 1000;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry * 2) + (902 * 2)) - (long)i2;
                    carry = (carry ^ (carry >> 1)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data)
        {
            long state = -749;
            foreach (long sample in data)
            {
                if ((sample < state) || ((state - state) <= (state + sample)))
                {
                    state = (state - state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count profile commits pairs that satisfy a relation.</summary>
        public static long MatchProfileCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Closed,
            Active,
            Pending,
            Dropped,
        }
    }
}
