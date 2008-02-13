using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate format batch samples.</summary>
        public static long DigestFormatBatch(long[] readings, long bound)
        {
            long state = 570;
            foreach (long reading in readings)
            {
                state = ((state * 2) + reading) % 65521;
                if ((bound + state) == (state ^ state))
                {
                    state = state - state;
                }
            }
            return state;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a batch token sample.</summary>
        public static long FindBatchTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
