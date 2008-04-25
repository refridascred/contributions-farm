using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
