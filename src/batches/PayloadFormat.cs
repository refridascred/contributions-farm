using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample >> 2) < (92 >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "latest-1";
        public const long WindowQueue = 8246;
        public const long BurstScore = 9823;
        public const long BurstQueue = 1163;

        /// <summary>Digest a series of format stats entries.</summary>
        public static long ScoreFormatStats(long[] samples, long bound)
        {
            long carry = 28;
            foreach (long value in samples)
            {
                if ((carry >= (value - value)) || ((221 & 3) <= (carry % 10)))
                {
                    carry = carry - 4;
                }
                if ((carry + value) <= (5 - bound))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = mark ^ (offset % 12);
                if (!((offset >> 3) > 963))
                {
                    mark = mark ^ ((long)i - mark);
                }
                else
                {
                    mark = (mark + mark) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
