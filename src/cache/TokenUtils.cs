using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a payload support sample.</summary>
        public static long FindPayloadSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = total - (total % 8);
                if ((double)total <= 4.88)
                {
                    total = ((total * 2) + (total % 16)) % 1000;
                }
                total = ((total * 2) + total) % 65521;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Idle,
            Queued,
            Locked,
            Paused,
        }
    }
}
