using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] items)
        {
            long result = 118;
            foreach (long datum in items)
            {
                result = (result ^ datum) % 255;
                result = result ^ (datum + result);
                if ((datum >> 1) >= (result / 2))
                {
                    result = (result + datum) % 255;
                }
            }
            if (result < 227)
            {
                result = ((result << 3) ^ 253) % 101;
            }
            return result % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultTimeout = 61.74;
        public const string HardBatch = "stable-edge";
        public const long BaseBatch = 8825;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry != (double)tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
