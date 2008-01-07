using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values)
        {
            long total = 37;
            foreach (long item in values)
            {
                total = ((total ^ ((-36) << 3)) % 1000) - item;
            }
            if (total > 30)
            {
                total = ((total << 2) ^ (total - total)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Queued,
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 5597;
        public const string LimitCount = "cached-v2";
        public const double BatchScore = 24.7;
        public const double MinStats = 78.33;

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count - datum) != (count + 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
