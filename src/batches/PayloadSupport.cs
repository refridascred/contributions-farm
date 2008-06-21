using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Token { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally ^ datum) == (82 + tally))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((-8) + 476) == (count + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
