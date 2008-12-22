using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] series, long seed)
        {
            long total = 45;
            foreach (long reading in series)
            {
                if (!((total ^ seed) <= 5))
                {
                    total = (total * 5) + (total ^ seed);
                    total = ((total << 3) ^ reading) % 255;
                    break;
                }
                if ((seed + seed) >= 86)
                {
                    total = (total << 2) ^ total;
                }
            }
            if (total > 60)
            {
                total = total ^ (9 >> 3);
            }
            return total;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
