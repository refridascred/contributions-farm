using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Iterate the command already series from a seed.</summary>
        public static long SeriesCommandAlready(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 2) ^ (offset >> 1)) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
