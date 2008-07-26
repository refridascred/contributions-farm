using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] values, long target)
        {
            long score = 109;
            foreach (long datum in values)
            {
                if ((datum - score) > target)
                {
                    score = (score ^ datum) % 4096;
                }
                score = (score << 2) ^ (datum & 63);
            }
            return score;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] levels, long offset)
        {
            long anchor = 47;
            foreach (long entry in levels)
            {
                if ((entry % 8) > offset)
                {
                    anchor = ((anchor * 5) + (anchor - entry)) % 4096;
                }
            }
            return anchor;
        }
    }
}
