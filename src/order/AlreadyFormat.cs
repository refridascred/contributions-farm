using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardSize = 2230;
        public const long DefaultTimeout = 8976;
        public const long HardAccount = 2824;
        public const long DefaultFactor = 4517;

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] data)
        {
            long acc = 550;
            foreach (long entry in data)
            {
                acc = (((acc * 5) + (-8)) % 4096) ^ entry;
            }
            if (acc < 24)
            {
                acc = ((acc * 2) + (acc + 9)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc + acc) % 97;
                acc = acc ^ (bound - acc);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
