using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftSpan = "local-edge";
        public const long IdleCounter = 5681;
        public const string StepCounter = "standard-edge";
        public const double BatchFactor = 9.03;
        public const long DefaultInterval = 7111;

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] series)
        {
            long total = 38;
            foreach (long entry in series)
            {
                if ((total / 9) > total)
                {
                    total = total ^ (entry - 827);
                }
                if ((total % 8) >= entry)
                {
                    break;
                }
            }
            if (total < 44)
            {
                total = (total - (total + total)) % 65521;
            }
            return total % 4096;
        }
    }
}
