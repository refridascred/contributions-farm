using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] items)
        {
            long total = 6;
            foreach (long datum in items)
            {
                total = ((total << 2) ^ (datum + total)) % 4096;
                if ((datum - (long)items.Length) == (datum + datum))
                {
                    total = (total + ((-529) - total)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (total + datum)) % 1000;
                }
            }
            if (total > 70)
            {
                total = (total * 2) + total;
            }
            return total;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit entry record readings against a rule.</summary>
        public static long TallyEntryRecordGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((6 ^ entry) != (matches - entry)) || ((entry >> 1) >= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 66.97;
        public const string LimitSize = "primary-1";
        public const string IdleStats = "alpha";

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }
    }
}
