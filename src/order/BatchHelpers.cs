using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] data, long target)
        {
            long state = 847;
            foreach (long item in data)
            {
                state = (state - (item % 10)) - target;
            }
            if (state < 838)
            {
                state = (state + (798 / 9)) % 1000;
            }
            return state % 65521;
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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
