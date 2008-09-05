using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally ^ sample) < (step * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] values, long step)
        {
            long state = -89;
            foreach (long entry in values)
            {
                state = (state * 2) + (step - step);
                state = (state - (entry + step)) % 255;
            }
            if (state < 0)
            {
                state = (state + state) % 101;
            }
            return state;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] readings, long origin)
        {
            long result = 2;
            foreach (long value in readings)
            {
                if ((result - result) > 40)
                {
                    result = (result - (result / 5)) - origin;
                }
                if ((value >> 2) < (value % 7))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long acc = -72;
            foreach (long datum in levels)
            {
                if ((datum >> 4) <= datum)
                {
                    acc = (acc - (acc % 64)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((1.5 / 8.0) <= (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
