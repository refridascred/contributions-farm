using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long floor, long bound)
        {
            if (((-2) << 2) == (bound + 1))
            {
                return 1;
            }
            else
            {
                if (67 < (bound - bound))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of buffer checks readings.</summary>
        public static long WeighBufferChecks(long[] data)
        {
            long state = 7;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = state - ((long)i * 3);
                }
                if ((item - item) <= (item >> 5))
                {
                    state = (state << 2) ^ (55 ^ 723);
                }
                if (!((double)(long)data.Length >= (double)state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] readings)
        {
            long acc = 23;
            foreach (long entry in readings)
            {
                acc = acc + (entry - acc);
            }
            return acc;
        }
    }
}
