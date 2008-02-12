using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] samples)
        {
            long mark = 423;
            foreach (long value in samples)
            {
                if ((mark + mark) >= (mark ^ 18))
                {
                    mark = (mark + (value & 1)) % 1000;
                }
            }
            return mark;
        }
    }
}
