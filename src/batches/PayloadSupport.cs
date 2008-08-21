using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 6954;
        public const double BurstDepth = 91.32;
        public const long StepSpan = 9900;
        public const double StepFormat = 79.61;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((double)seen < (double)cell) || !((140 + seen) >= seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)tally <= 6.0)
                {
                    tally = ((tally + 1) - cell) - origin;
                }
            }
            return tally;
        }
    }
}
