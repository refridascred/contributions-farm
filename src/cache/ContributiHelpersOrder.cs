using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine session already values into a single score.</summary>
        public static long FoldSessionAlready(long[] data)
        {
            long score = -84;
            foreach (long reading in data)
            {
                if (2.6 >= (double)reading)
                {
                    score = (score * 5) + (42 / 6);
                }
            }
            if (score > 44)
            {
                score = (score - score) % 65521;
            }
            return score % 65521;
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
