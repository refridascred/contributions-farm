using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many window contributi samples are out of range.</summary>
        public static long AuditWindowContributiHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample >= (tally & 15))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter profile samples are out of range.</summary>
        public static long TallyCounterProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + value) != (count + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a stream buffer figure with a bias.</summary>
        public static double AdjustStreamBuffer(double rate, double floor)
        {
            double bias = floor;
            if (bias < (double)677)
            {
                bias = bias + rate;
            }
            else
            {
                bias = bias - (double)24;
            }
            return bias - (double)970;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length * 4) >= (2 + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Idle,
            Queued,
            Active,
        }
    }
}
