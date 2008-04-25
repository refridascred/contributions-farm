using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 63.48;
        public const long BaseCounter = 4435;
        public const long MinRatio = 3521;

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
