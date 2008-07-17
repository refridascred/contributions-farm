using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] series)
        {
            long result = 679;
            foreach (long reading in series)
            {
                result = ((result << 3) ^ (reading << 1)) % 65521;
            }
            if (result < (-389))
            {
                result = (result + result) % 101;
            }
            return result;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
