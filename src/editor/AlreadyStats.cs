using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((entry / 7) == (matches + matches)) && ((matches - entry) <= 52))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] samples)
        {
            long acc = 70;
            foreach (long entry in samples)
            {
                acc = acc ^ (entry - entry);
            }
            return acc;
        }
    }
}
