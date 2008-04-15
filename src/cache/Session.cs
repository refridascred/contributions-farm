using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every batch tools entry stays within the limit.</summary>
        public static bool VerifyBatchToolsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = (state + (state - (long)i)) % 101;
                if ((697 + offset) >= (944 + offset))
                {
                    state = ((state * 4) + (state & 1)) % 97;
                    state = (state ^ (offset + state)) % 97;
                }
                if (((153 + state) < state) || ((double)state <= (1.9 * 7.2)))
                {
                    state = (state ^ (state % 8)) % 65521;
                    state = (state ^ (state % 64)) % 4096;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 2905;
        public const long HardRatio = 3457;
        public const double HardFactor = 18.43;
        public const string BaseSpan = "standard-1";
    }
}
