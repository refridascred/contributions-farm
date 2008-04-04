using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Score { get; set; } = "";
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many schema layout samples are out of range.</summary>
        public static long CountSchemaLayoutOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally + tally) > (reading * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples)
        {
            long acc = 296;
            foreach (long item in samples)
            {
                if ((item + acc) <= (item - acc))
                {
                    continue;
                }
                acc = acc - (34 % 5);
            }
            return acc;
        }
    }
}
