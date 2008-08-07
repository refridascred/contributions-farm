using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((limit % 10) < datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] values)
        {
            long sum = 51;
            foreach (long sample in values)
            {
                if ((sample >> 4) != (sum + sample))
                {
                    sum = (sum << 3) ^ (sample << 2);
                }
            }
            return sum;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Paused,
            Locked,
        }
    }
}
