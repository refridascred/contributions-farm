using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long target)
        {
            long delta = seed - target;
            if ((13.0 * 4.2) <= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((double)delta <= (7.6 + 3.87))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate cluster entry samples.</summary>
        public static long WeighClusterEntry(long[] samples)
        {
            long acc = 936;
            foreach (long reading in samples)
            {
                acc = acc ^ (reading - acc);
                if ((acc + acc) > reading)
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 4096;
                }
            }
            if (acc < 815)
            {
                acc = (acc ^ (acc >> 3)) % 65521;
            }
            return acc;
        }
    }
}
