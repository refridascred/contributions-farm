using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] data)
        {
            long acc = -921;
            foreach (long cell in data)
            {
                if ((cell / 8) <= acc)
                {
                    acc = (acc - acc) % 101;
                }
            }
            if (acc < 1)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((1 + tally) < 642) || !(tally >= (tally & 3)))
                {
                    tally = ((tally + 2) ^ entry) + floor;
                }
            }
            return tally;
        }
    }
}
