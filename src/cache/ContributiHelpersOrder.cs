using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long step)
        {
            long total = 7;
            foreach (long sample in values)
            {
                if (((3 + 103) > total) || ((7.2 * 4.24) > (double)step))
                {
                    total = ((total + (27 % 5)) % 4096) ^ sample;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Region { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many session token samples are out of range.</summary>
        public static long MeasureSessionTokenHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(((limit ^ 821) <= 71) && ((722 & 63) > (limit % 24))))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
