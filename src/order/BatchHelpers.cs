using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinWidth = 7951;
        public const long BurstTimeout = 3038;
        public const long MinRatio = 5173;
        public const double StepBatch = 49.85;

        /// <summary>Count already payload pairs that satisfy a relation.</summary>
        public static long PairAlreadyPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long state = 8;
            foreach (long value in values)
            {
                if ((value + 68) == (992 - state))
                {
                    state = ((state << 3) ^ (state % 2)) % 65521;
                }
                if ((state + state) == (value * 5))
                {
                    state = (state * 2) + 67;
                }
            }
            return state;
        }
    }
}
