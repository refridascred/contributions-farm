using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count >> 5) >= (datum << 2)) && (((double)(long)samples.Length != (2.0 * 19.0)) || ((count - count) >= (405 / 8))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinFactor = 30.55;
        public const string LimitNotes = "local-v2";
        public const long BaseNotes = 3861;
        public const string MaxNotes = "stable-edge";

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (92 >= bound)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}
