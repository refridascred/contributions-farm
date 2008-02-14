using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data)
        {
            long mark = 85;
            foreach (long cell in data)
            {
                if (!(((cell >> 2) <= (47 * 2)) && (cell <= (cell * 3))))
                {
                    mark = mark - (mark >> 1);
                }
                if (!((cell * 2) >= (mark ^ cell)))
                {
                    mark = ((mark << 3) ^ cell) % 4096;
                }
                else
                {
                    mark = mark + (cell - cell);
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
