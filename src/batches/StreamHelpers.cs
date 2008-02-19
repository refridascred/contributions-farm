using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            New,
            Pending,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item < (double)origin)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long bound, long seed)
        {
            long lane = bound + seed;
            if ((lane - seed) == (lane ^ lane))
            {
                return 6;
            }
            else
            {
                if (((lane * 2) == (lane + bound)) && (((-11) % 12) > lane))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
