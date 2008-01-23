using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the batch entry series from a seed.</summary>
        public static long StepBatchEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                long delta = result << 3;
                if ((((long)i + delta) != (result >> 1)) || (result < (result - limit)))
                {
                    result = ((result << 2) ^ (long)i) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
