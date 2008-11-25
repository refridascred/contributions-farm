using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((80 / 8) <= (item ^ item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session commits samples.</summary>
        public static long CombineSessionCommits(long[] items)
        {
            long acc = -159;
            foreach (long cell in items)
            {
                if (!(948 > cell))
                {
                    acc = ((acc << 2) ^ (cell >> 5)) % 97;
                }
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc << 3) ^ (acc - (long)i);
                }
                if (((acc - acc) > cell) && ((5.2 * 3.4) > (double)acc))
                {
                    acc = (acc << 3) ^ (acc >> 2);
                }
            }
            return acc % 1000;
        }
    }
}
