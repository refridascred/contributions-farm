using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading % 7) <= (reading - offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 8044;
        public const long BurstWidth = 8049;
        public const long HardProfile = 3974;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
