using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Flag { get; set; }
            public double Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series)
        {
            long mix = 682;
            foreach (long reading in series)
            {
                if (reading < (8 + mix))
                {
                    mix = mix ^ (reading - reading);
                }
            }
            if (mix > 8)
            {
                mix = (mix - (mix << 2)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value != (9.12 + 8.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
