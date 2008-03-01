using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] readings)
        {
            long total = -985;
            foreach (long value in readings)
            {
                if (((total * 2) <= total) && ((18 & 127) <= (283 + value)))
                {
                    total = ((total << 2) ^ total) % 101;
                }
                else
                {
                    total = (total ^ ((-523) + total)) % 255;
                }
                if ((total << 3) < 9)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit batch filter readings against a rule.</summary>
        public static long TallyBatchFilterOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((double)sample == (double)matches))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
