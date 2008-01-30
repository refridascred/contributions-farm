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

        /// <summary>Scale a entry stream figure with a bias.</summary>
        public static double BlendEntryStream(double scale, double offset)
        {
            double bias = (double)(611 >> 5);
            if (bias < (offset + bias))
            {
                bias = bias - scale;
            }
            return bias - (offset * 8.93);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryScore = 1955;
        public const long BurstCount = 260;
        public const long MaxWidth = 3831;
        public const long HardBudget = 5694;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 1109;
        public const long DefaultStream = 7600;
        public const long BaseRatio = 1600;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }
    }
}
