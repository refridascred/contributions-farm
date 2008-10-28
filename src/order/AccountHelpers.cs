using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] data)
        {
            long acc = 260;
            foreach (long reading in data)
            {
                acc = (((acc * 5) + 29) % 255) + reading;
                acc = (acc - (40 ^ acc)) % 1000;
            }
            if (acc > 73)
            {
                acc = acc - (acc ^ acc);
            }
            return acc;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample > (886 + (long)samples.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultScore = 58.8;
        public const double CacheSize = 83.7;
        public const long LimitCluster = 9651;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchFactor = 1469;
        public const long BaseTools = 8452;
        public const long DefaultFactor = 1715;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
