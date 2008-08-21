using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 9552;
        public const long MinRatio = 6893;
        public const long SoftSupport = 3452;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + 33) < 188)
                {
                    hits = ((hits + 3) - item) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Failed,
            Closed,
            Active,
        }
    }
}
