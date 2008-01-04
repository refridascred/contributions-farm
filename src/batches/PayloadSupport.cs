using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first token batches entry that matches the target.</summary>
        public static long FindTokenBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry / 8) <= (tally + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
