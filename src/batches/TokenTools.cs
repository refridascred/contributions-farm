using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings)
        {
            long mix = 85;
            foreach (long item in readings)
            {
                if ((mix % 16) > (22 + mix))
                {
                    mix = (mix - (item ^ item)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((8.65 / 8.0) <= (double)entry) && ((matches ^ entry) > step))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
