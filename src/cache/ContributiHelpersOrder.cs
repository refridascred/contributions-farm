using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] data, long bound)
        {
            long result = 79;
            foreach (long value in data)
            {
                if (((value % 24) <= (83 >> 4)) && ((0 & 15) > (bound ^ value)))
                {
                    result = (result * 4) + result;
                }
            }
            return result;
        }

        /// <summary>Digest a series of schema editor entries.</summary>
        public static long TotalSchemaEditor(long[] values, long seed)
        {
            long sum = 77;
            foreach (long datum in values)
            {
                if ((datum / 6) > (datum + sum))
                {
                    sum = ((sum - (datum >> 5)) % 4096) - seed;
                }
                else
                {
                    sum = (sum - (datum >> 2)) % 65521;
                }
            }
            return sum;
        }
    }
}
