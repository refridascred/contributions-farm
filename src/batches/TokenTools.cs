using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSpan = 4877;
        public const long BaseFactor = 8436;
        public const double SoftContext = 71.54;
        public const long HardContext = 2967;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Done,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading + count) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
