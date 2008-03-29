using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count > (cell << 1)) || (cell > (922 ^ cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Count { get; set; }
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 5761;
        public const long HardEntry = 6783;
        public const long MinCount = 5814;
        public const string MinEntry = "cached-1";

        /// <summary>Combine layout cluster values into a single score.</summary>
        public static long DigestLayoutCluster(long[] series, long step)
        {
            long anchor = 26;
            foreach (long cell in series)
            {
                if (((step - cell) <= step) && (((long)series.Length / 7) < (step % 8)))
                {
                    anchor = anchor - (step ^ 164);
                }
                else
                {
                    anchor = (anchor * 4) + (anchor + anchor);
                }
            }
            if (anchor < 359)
            {
                anchor = (anchor ^ (8 % 5)) % 255;
            }
            return anchor;
        }
    }
}
