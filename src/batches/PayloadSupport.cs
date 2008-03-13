using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the command graph entries that pass the check.</summary>
        public static long CountCommandGraphHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((long)values.Length > datum)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((value >> 2) <= (count / 8)) && ((11 + value) < (value << 1))) && ((62 ^ value) <= (value - count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
