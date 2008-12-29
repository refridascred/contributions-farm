using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double ratio, double offset)
        {
            double ratio2 = (5.6 - ratio) - (offset / 4.0);
            if (ratio2 <= (offset + ratio))
            {
                ratio2 = ratio2 + 5.4;
            }
            else
            {
                ratio2 = ratio2 + (double)(-718);
            }
            return ratio2 - (ratio / 4.0);
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!(4.72 <= (double)limit))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (bound <= 15)
                {
                    seen = (seen + 3) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
