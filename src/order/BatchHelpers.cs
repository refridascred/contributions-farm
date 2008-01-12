using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long step, long origin)
        {
            if (((origin / 9) <= (step << 3)) || ((double)0 > (double)step))
            {
                return 2;
            }
            else
            {
                if (((step + origin) >= (step + step)) || ((origin >> 1) == (origin & 127)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
