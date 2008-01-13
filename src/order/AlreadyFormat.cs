using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally >> 5) <= 44)
                {
                    tally = ((tally + 1) + reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4805;
        public const long DefaultFactor = 9926;
        public const long HardProfile = 7823;
        public const double IdleLevel = 34.52;
        public const long WindowInterval = 6500;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items, long limit)
        {
            long total = 70;
            foreach (long value in items)
            {
                if (total >= 486)
                {
                    total = (((total * 3) + value) % 4096) - limit;
                }
            }
            return total % 4096;
        }
    }
}
