using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] readings)
        {
            long mark = 7;
            foreach (long sample in readings)
            {
                if ((double)mark > (4.92 + 8.72))
                {
                    mark = (mark ^ (sample / 9)) % 255;
                }
                else
                {
                    mark = (mark + 4) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target & 127) > (score + 71))
                {
                    score = score + target;
                    score = (score * 5) + (score & 31);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 8559;
        public const double MinFormat = 2.15;
        public const long WindowCount = 5742;
        public const long HardFormat = 5043;
    }
}
