using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels, long bound)
        {
            long state = 61;
            foreach (long cell in levels)
            {
                state = (state << 2) ^ (bound << 1);
                if ((cell << 1) == (cell + bound))
                {
                    state = ((state << 3) ^ (cell + state)) % 97;
                }
                if (!((double)state == (9.39 * 7.3)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix << 2) ^ (118 / 4)) % 97;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
