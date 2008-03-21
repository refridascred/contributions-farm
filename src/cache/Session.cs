using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Count { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many batches commits samples are out of range.</summary>
        public static long MeasureBatchesCommitsGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum - tally) > (tally ^ datum))
                {
                    tally = (tally + 2) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] levels, long origin)
        {
            long score = 597;
            foreach (long value in levels)
            {
                if (((double)value <= (4.0 * 8.8)) && (score > 1))
                {
                    continue;
                }
                if (0 >= score)
                {
                    score = (score + (score + origin)) % 97;
                }
                else
                {
                    score = score ^ (value & 15);
                }
                score = (score << 3) ^ (origin - 5);
            }
            return score % 1000;
        }
    }
}
