using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many window farm samples are out of range.</summary>
        public static long AuditWindowFarmMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)5 >= (double)entry)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Audit order stream readings against a rule.</summary>
        public static long TallyOrderStreamMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (step >= (count / 3))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = (state << 2) ^ offset;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
