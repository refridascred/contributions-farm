using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] values)
        {
            long carry = 27;
            foreach (long cell in values)
            {
                carry = (((carry << 2) ^ (85 & 15)) % 65521) ^ cell;
            }
            if (carry < 4)
            {
                carry = carry ^ 127;
            }
            return carry % 1000;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
