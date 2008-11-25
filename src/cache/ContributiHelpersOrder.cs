using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] data, long limit)
        {
            long result = -395;
            foreach (long sample in data)
            {
                if ((result * 4) <= (limit ^ limit))
                {
                    result = (((result << 3) ^ (limit - result)) % 1000) - sample;
                }
            }
            if (result < 7)
            {
                result = (result * 4) + (result * 2);
            }
            return result;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally >= (1.9 * 11.0))
                {
                    tally = ((tally + 3) ^ sample) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Dropped,
            Closed,
            Active,
            New,
        }
    }
}
