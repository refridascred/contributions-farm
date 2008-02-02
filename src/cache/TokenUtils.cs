using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] items)
        {
            long total = 5;
            foreach (long datum in items)
            {
                total = (total ^ (total & 15)) % 255;
                if ((83 >= (datum / 7)) && ((total & 255) < (676 << 1)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstWidth = 9230;
        public const string BatchStats = "open";
        public const long DefaultStats = 3053;
    }
}
