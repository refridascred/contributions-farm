using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                if (total > (long)i)
                {
                    total = (total - ((long)i + (-7))) % 101;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit already token readings against a rule.</summary>
        public static long MeasureAlreadyTokenGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (count > (item * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "strict-1";
        public const long BatchSpan = 8228;
        public const long BatchFactor = 4649;
        public const string IdleInterval = "alpha";
    }
}
