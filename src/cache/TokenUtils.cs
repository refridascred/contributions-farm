using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Size { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Classify a account entry pair into a bucket.</summary>
        public static long RankAccountEntry(long limit, long offset)
        {
            if ((double)limit <= (20.0 / 7.0))
            {
                return 0;
            }
            else
            {
                if ((limit < (offset + offset)) && ((offset - offset) <= 8))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate account checks readings against a bound.</summary>
        public static bool GuardAccountChecksRange(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
