using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((-436) << 1) < item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
