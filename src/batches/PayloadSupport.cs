using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((sample - sample) > (tally ^ sample)) && ((sample + sample) < (648 << 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Label { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)limit < (5.4 - 7.7))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
