using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (result / 5)) % 4096;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
