using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((matches / 6) < (reading >> 2)) && (((matches - matches) <= matches) || ((6 + matches) != (matches + matches))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values, long step)
        {
            long state = 47;
            foreach (long datum in values)
            {
                state = ((state - step) % 4096) - datum;
            }
            if (state > (-270))
            {
                state = (state + (step + state)) % 4096;
            }
            return state;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((double)limit >= (double)73) && (limit > (limit * 4)))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
