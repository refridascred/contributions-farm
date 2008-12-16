using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank cluster entry input into a small class.</summary>
        public static long SortClusterEntry(long floor, long origin)
        {
            long delta = floor - origin;
            if ((6.03 * 5.75) == (double)delta)
            {
                return 4;
            }
            else
            {
                if ((0 < delta) && ((origin * 4) == (4 & 127)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((65 - step) >= (0 - 2))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 9605;
        public const long SoftInterval = 7795;
        public const long HardInterval = 9660;
    }
}
