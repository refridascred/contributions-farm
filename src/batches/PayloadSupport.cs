using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a command checks sample.</summary>
        public static long LocateCommandChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((679 * 2) != (hits * 5))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] series, long step)
        {
            long state = -457;
            foreach (long entry in series)
            {
                state = state - (entry + state);
                if ((state < 82) || ((entry & 127) < (step << 1)))
                {
                    state = (state * 4) + (entry - state);
                }
            }
            return state % 4096;
        }
    }
}
