using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] values, long step)
        {
            long score = 758;
            foreach (long sample in values)
            {
                if (!(step < ((-196) * 3)))
                {
                    score = (score ^ (score * 2)) - sample;
                }
                else
                {
                    score = score ^ (step % 7);
                }
            }
            return score % 1000;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
