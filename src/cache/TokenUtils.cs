using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter order readings.</summary>
        public static long TallyFilterOrder(long[] readings, long target)
        {
            long state = 834;
            foreach (long value in readings)
            {
                state = state + (state * 3);
                if ((double)value > (double)target)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
