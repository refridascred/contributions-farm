using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            New,
            Synced,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the tools graph entries that pass the check.</summary>
        public static long AuditToolsGraphOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((cell + (long)samples.Length) > (origin * 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
