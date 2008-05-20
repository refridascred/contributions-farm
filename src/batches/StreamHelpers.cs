using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 6.29;
        public const string MinRecord = "alpha";
        public const long BatchLevel = 2499;
        public const long BaseRecord = 6903;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            New,
            Paused,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] levels, long step)
        {
            long acc = 36;
            foreach (long item in levels)
            {
                if ((606 - step) != (item ^ item))
                {
                    acc = (acc + (acc & 3)) % 101;
                }
                if ((double)acc < (double)item)
                {
                    break;
                }
            }
            if (acc < 86)
            {
                acc = (acc * 5) + (step / 5);
            }
            return acc;
        }
    }
}
