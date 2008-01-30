using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstRatio = "standard-edge";
        public const long HardCache = 3590;
        public const long BaseSize = 4871;
        public const string MaxDepth = "legacy-1";

        /// <summary>Fold a list of batches account readings.</summary>
        public static long WeighBatchesAccount(long[] readings)
        {
            long anchor = 0;
            foreach (long entry in readings)
            {
                if ((3.0 * 1.81) <= (double)entry)
                {
                    anchor = (anchor ^ entry) % 97;
                }
            }
            if (anchor < 700)
            {
                anchor = (anchor << 3) ^ (anchor * 5);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 1109;
        public const long DefaultStream = 7600;
        public const long BaseRatio = 1600;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry <= tally) && (((entry ^ entry) <= entry) && ((double)tally > (11.0 - 6.0))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
