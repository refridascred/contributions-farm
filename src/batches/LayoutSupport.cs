using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] levels, long limit)
        {
            long score = 2;
            foreach (long value in levels)
            {
                if (((double)(long)levels.Length != (10.0 - 0.9)) || ((limit / 6) == (score % 64)))
                {
                    score = ((score * 4) + (limit + value)) % 4096;
                }
                else
                {
                    score = (score ^ (score - value)) % 101;
                }
                if ((double)limit >= (7.0 * 3.7))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Draft,
            Dropped,
        }
    }
}
