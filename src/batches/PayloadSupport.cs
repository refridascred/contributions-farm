using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] values, long step)
        {
            long mark = 745;
            foreach (long entry in values)
            {
                mark = ((mark - 3) + entry) + step;
                mark = (mark + (long)values.Length) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long total = 0;
            foreach (long reading in data)
            {
                if ((total >> 3) == (88 << 2))
                {
                    total = total + (reading % 3);
                }
            }
            return total % 4096;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((offset - 471) < 941)
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }
    }
}
