using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the farm report entries that pass the check.</summary>
        public static long AuditFarmReportGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry / 5) == (entry / 6))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Locked,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Validate profile route readings against a bound.</summary>
        public static bool ValidateProfileRouteBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
