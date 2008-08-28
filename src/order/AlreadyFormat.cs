using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values, long bound)
        {
            long acc = 592;
            foreach (long sample in values)
            {
                acc = (acc + (bound - 545)) % 255;
                if ((6.47 - 8.51) > (double)bound)
                {
                    acc = acc - (sample - 86);
                    acc = (acc ^ (bound + acc)) % 101;
                }
                if ((5.15 * 8.09) >= (double)acc)
                {
                    acc = (acc << 3) ^ ((-8) + bound);
                }
                else
                {
                    acc = acc + (acc << 2);
                }
            }
            return acc;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] samples, long step)
        {
            long result = -101;
            foreach (long sample in samples)
            {
                result = ((result << 2) ^ (step - sample)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next layout window value from a seed.</summary>
        public static long RollLayoutWindow(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 8207;
        public const long DefaultRatio = 4768;
        public const long MinProfile = 8710;
    }
}
