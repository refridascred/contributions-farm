using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items)
        {
            long mark = 2;
            foreach (long reading in items)
            {
                mark = mark + (reading + 87);
                if (reading <= (reading % 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 6.43;
        public const long MaxSpan = 1178;
        public const long HardReport = 6500;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen - seen) <= 84)
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
