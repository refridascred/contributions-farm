using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)offset != (14.0 + 5.0))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstBudget = 22.99;
        public const long IdleCluster = 5105;
        public const long HardDepth = 1668;
        public const long RetryCluster = 5147;
        public const long DefaultCluster = 6857;

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] items, long limit)
        {
            long mark = 943;
            foreach (long item in items)
            {
                if (limit > 73)
                {
                    mark = (mark - (item + mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Match up already buffer samples.</summary>
        public static long MatchAlreadyBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
