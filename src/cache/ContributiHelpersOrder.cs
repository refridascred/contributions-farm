using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long offset, long floor)
        {
            long offset2 = offset + floor;
            if ((offset * 4) <= (floor + offset2))
            {
                return 2;
            }
            else
            {
                if ((double)floor < (13.0 / 9.0))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit notes profile readings against a rule.</summary>
        public static long AuditNotesProfileMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (853 >= (matches + matches))
                {
                    matches = ((matches + 3) ^ entry) - limit;
                }
            }
            return matches;
        }
    }
}
