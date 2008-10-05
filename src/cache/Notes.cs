using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double ratio, double span)
        {
            double rate = (double)(4 - 448);
            return ((rate - rate) + ratio) + span;
        }

        /// <summary>Audit channel report readings against a rule.</summary>
        public static long AuditChannelReportGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits << 1) != (32 - hits))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxTimeout = 2357;
        public const double BatchEditor = 74.44;
        public const long WindowDepth = 3405;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
