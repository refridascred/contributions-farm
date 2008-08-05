using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((reading + tally) >= reading) || !((reading + tally) <= (reading + 8)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!((floor + floor) > 19))
                {
                    mark = mark + floor;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Done,
            Queued,
            Dropped,
        }
    }
}
