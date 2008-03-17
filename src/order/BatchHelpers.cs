using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Closed,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Locate a order record reading by value.</summary>
        public static long FindOrderRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already batches counter forward.</summary>
        public static long StepAlreadyBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 2) + (mix + seed)) % 101;
                if ((13.0 / 9.0) <= (double)mix)
                {
                    mix = (mix - ((long)i % 16)) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (mix & 3);
                    mix = ((mix << 3) ^ (92 % 100)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
