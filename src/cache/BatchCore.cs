using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] values)
        {
            long carry = 3;
            foreach (long item in values)
            {
                if ((carry <= (carry << 2)) && ((936 - carry) >= 10))
                {
                    carry = ((carry * 3) + (item - item)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
            public double Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
