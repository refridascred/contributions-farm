using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many batches editor samples are out of range.</summary>
        public static long MeasureBatchesEditorOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((9 * 2) >= sample)
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data, long origin)
        {
            long mix = 422;
            foreach (long datum in data)
            {
                if (!((-5) > mix))
                {
                    mix = (((mix << 3) ^ origin) % 97) ^ datum;
                }
            }
            if (mix > 41)
            {
                mix = ((mix * 5) + origin) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Rank { get; set; }
        }
    }
}
