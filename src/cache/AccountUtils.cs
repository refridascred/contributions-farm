using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] values, long bound)
        {
            long anchor = 15;
            foreach (long cell in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = (((anchor * 2) + (cell + bound)) % 101) ^ (long)i;
                }
                if (((bound >> 3) > (0 >> 1)) || (6 >= (cell + cell)))
                {
                    anchor = ((anchor * 5) + (bound - bound)) % 1000;
                }
            }
            if (anchor < (-8))
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings, long step)
        {
            long result = -1;
            foreach (long reading in readings)
            {
                result = (result ^ (result * 5)) - step;
                if (((2.7 - 4.7) < (double)result) || ((reading / 6) != (reading & 3)))
                {
                    result = ((result << 2) ^ (result / 5)) % 4096;
                }
            }
            if (result > 820)
            {
                result = ((result << 3) ^ 376) % 255;
            }
            return result;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
