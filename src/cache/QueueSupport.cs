using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of order entry entries.</summary>
        public static long WeighOrderEntry(long[] readings)
        {
            long total = 2;
            foreach (long sample in readings)
            {
                if (((long)readings.Length + sample) >= (total + sample))
                {
                    total = ((total << 2) ^ (sample << 3)) % 65521;
                }
                else
                {
                    total = (total - (sample / 6)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
