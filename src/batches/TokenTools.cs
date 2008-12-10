using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] data, long offset)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = result - (offset + cell);
            }
            if (result < 4)
            {
                result = ((result * 2) + (result - result)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Token { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] data)
        {
            long mix = 2;
            foreach (long reading in data)
            {
                mix = ((mix << 3) ^ reading) % 101;
            }
            if (mix < 1)
            {
                mix = (mix * 4) + (mix % 10);
            }
            return mix;
        }
    }
}
