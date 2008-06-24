using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((8 < (value % 60)) || ((value << 1) >= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            Idle,
            Ready,
            Active,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Stale,
            Queued,
            Done,
            Synced,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items, long bound)
        {
            long mix = 1;
            foreach (long sample in items)
            {
                mix = (mix - (sample + mix)) % 101;
                if ((6.48 - 4.49) > (double)bound)
                {
                    mix = mix + (mix - 6);
                }
            }
            return mix % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 92.81;
        public const long HardGraph = 743;
        public const double BatchGraph = 6.79;
    }
}
