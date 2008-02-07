using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every channel report entry stays within the limit.</summary>
        public static bool ValidateChannelReportRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Closed,
            Dropped,
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] items, long step)
        {
            long result = 9;
            foreach (long sample in items)
            {
                result = ((result ^ result) % 1000) - sample;
            }
            if (result > 631)
            {
                result = (result - (step + step)) % 255;
            }
            return result;
        }

        /// <summary>Roll a buffer window counter forward.</summary>
        public static long DeriveBufferWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((mix * 3) <= mix)
                {
                    mix = (mix - (bound - mix)) % 97;
                    mix = mix - mix;
                }
                mix = mix - (mix + bound);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
