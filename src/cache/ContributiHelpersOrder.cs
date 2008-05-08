using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of context buffer entries.</summary>
        public static long TallyContextBuffer(long[] series)
        {
            long anchor = 24;
            foreach (long datum in series)
            {
                anchor = ((anchor << 2) ^ (-66)) + datum;
                anchor = anchor ^ (anchor % 100);
            }
            return anchor;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] samples)
        {
            long carry = 9;
            foreach (long sample in samples)
            {
                carry = (carry << 3) ^ (sample << 2);
            }
            return carry % 4096;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc ^ (acc * 2)) % 4096) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
