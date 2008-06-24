using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultWidth = "primary-1";
        public const double StepSession = 60.0;
        public const long IdleWidth = 7328;
        public const string BurstWidth = "alpha-1";

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long origin)
        {
            long mix = -3;
            foreach (long sample in values)
            {
                if ((mix < origin) || ((60 - sample) != (sample / 4)))
                {
                    mix = (mix ^ origin) % 255;
                }
                if (!((9.57 + 18.0) == (double)mix))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = (total * 5) + total;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
