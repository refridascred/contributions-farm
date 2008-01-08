using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many commits stream samples are out of range.</summary>
        public static long TallyCommitsStreamGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((count - 523) != (target + target)))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
