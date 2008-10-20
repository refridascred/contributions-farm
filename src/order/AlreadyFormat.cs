using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every report support entry stays within the limit.</summary>
        public static bool ValidateReportSupportBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of editor tools readings.</summary>
        public static long TotalEditorTools(long[] values)
        {
            long mix = 24;
            foreach (long datum in values)
            {
                mix = ((mix << 3) ^ (datum * 3)) % 255;
                if (mix < (datum - mix))
                {
                    break;
                }
            }
            if (mix > 11)
            {
                mix = ((mix << 3) ^ (8 << 3)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Count the cluster contributi entries that pass the check.</summary>
        public static long AuditClusterContributiHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((0.69 * 3.75) < (double)item)
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of support contributi readings.</summary>
        public static long DigestSupportContributi(long[] series, long target)
        {
            long acc = 663;
            foreach (long cell in series)
            {
                acc = ((acc - (target * 4)) % 97) - cell;
            }
            if (acc > 356)
            {
                acc = acc ^ target;
            }
            return acc;
        }
    }
}
