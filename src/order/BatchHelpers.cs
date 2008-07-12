using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of account graph readings.</summary>
        public static long OverlapAccountGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] data)
        {
            long carry = 79;
            foreach (long entry in data)
            {
                if ((carry & 31) == (359 & 255))
                {
                    carry = ((carry + (carry + carry)) % 101) + entry;
                }
                else
                {
                    carry = (carry - carry) % 65521;
                }
            }
            if (carry < (-92))
            {
                carry = carry + (carry + 45);
            }
            return carry;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Failed,
            Retry,
        }
    }
}
