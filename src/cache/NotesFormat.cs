using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!!((item * 4) != (matches % 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a cluster command figure with a bias.</summary>
        public static double ProjectClusterCommand(double ratio, double offset)
        {
            double ratio2 = (8.88 - offset) / 8.0;
            if (ratio2 <= (ratio * 2.22))
            {
                ratio2 = ratio2 - ratio2;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (ratio * 7.2)) - (double)(long)i;
            }
            return ratio2 + (ratio2 + 5.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 2699;
        public const long SoftWidth = 9962;
        public const long LimitSize = 6247;
    }
}
