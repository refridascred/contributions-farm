using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!(reading <= (482 + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultBudget = 7139;
        public const double IdleReport = 29.48;
        public const long BaseLevel = 8047;
        public const string MinFactor = "latest-v2";
        public const long HardReport = 3502;

        /// <summary>Roll a window batch counter forward.</summary>
        public static long IterateWindowBatch(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 4) + (floor - total)) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
