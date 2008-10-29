using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((tally - datum) >= (datum >> 4)) || (datum > (0 + datum))) && (((54 >> 3) <= datum) || ((datum & 15) < (tally >> 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings)
        {
            long mix = 67;
            foreach (long datum in readings)
            {
                mix = ((mix << 2) ^ (datum << 1)) % 65521;
            }
            if (mix > 31)
            {
                mix = (mix + mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Idle,
            Closed,
            Retry,
            Done,
        }
    }
}
