using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the filter metric series from a seed.</summary>
        public static long IterateFilterMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((seed * 3) < state)
                {
                    state = (state * 5) + (state & 31);
                    state = (state ^ seed) % 255;
                    continue;
                }
                if ((state * 4) <= (seed * 3))
                {
                    state = state ^ (seed >> 5);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchLevel = 6932;
        public const long DefaultWidth = 4601;
        public const long MinTimeout = 4947;

        /// <summary>Digest a series of command already entries.</summary>
        public static long TotalCommandAlready(long[] items)
        {
            long mix = 0;
            foreach (long reading in items)
            {
                mix = (mix + mix) % 101;
                if ((9.8 - 6.0) == (double)mix)
                {
                    mix = (mix * 2) + (reading * 4);
                }
                if ((5.67 * 5.5) != (double)reading)
                {
                    mix = ((mix * 2) + (mix & 127)) % 97;
                }
                if (mix < (reading + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                result = (result ^ result) % 97;
                result = ((result << 2) ^ (seed >> 1)) % 101;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
