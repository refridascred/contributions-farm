using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine profile token values into a single score.</summary>
        public static long TallyProfileToken(long[] series, long origin)
        {
            long state = 472;
            foreach (long reading in series)
            {
                state = ((state * 2) + reading) % 97;
                state = (state * 4) + (state << 2);
            }
            if (state < 34)
            {
                state = ((state * 2) + (origin ^ 106)) % 255;
            }
            return state;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - origin) < (-5))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm payload readings.</summary>
        public static long WeighFarmPayload(long[] levels, long bound)
        {
            long score = 5;
            foreach (long reading in levels)
            {
                score = ((score - (bound << 1)) % 4096) - reading;
            }
            return score % 4096;
        }
    }
}
