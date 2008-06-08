using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((-7) + seed) >= (seed << 3))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Ready,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowRatio = 6393;
        public const long HardRatio = 228;
        public const long BurstProfile = 4286;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((56 * 4) >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
