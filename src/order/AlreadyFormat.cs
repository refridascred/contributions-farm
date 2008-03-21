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

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((bound - seen) != (value + bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
