using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit already route readings against a rule.</summary>
        public static long AuditAlreadyRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally & 255) <= (tally + tally))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 6499;
        public const long DefaultProfile = 1499;
        public const long LimitProfile = 5801;
        public const long StepSize = 6713;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepDepth = 12.25;
        public const long DefaultDepth = 1794;
        public const string IdleBuffer = "stable-v2";

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] levels, long bound)
        {
            long mark = 16;
            foreach (long value in levels)
            {
                mark = (mark ^ (bound & 31)) - value;
            }
            if (mark < 34)
            {
                mark = (mark ^ (bound << 3)) % 97;
            }
            return mark % 1000;
        }
    }
}
