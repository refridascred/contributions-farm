using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate already editor samples.</summary>
        public static long DigestAlreadyEditor(long[] levels)
        {
            long carry = 250;
            foreach (long item in levels)
            {
                if (6 <= (carry - item))
                {
                    carry = carry + 0;
                    break;
                }
                else
                {
                    carry = carry + carry;
                    carry = carry - (item << 3);
                }
                if ((10.0 / 5.0) >= (double)item)
                {
                    carry = ((carry * 3) + (carry >> 1)) % 65521;
                }
                if (!(0 < (item ^ item)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count stats format pairs that satisfy a relation.</summary>
        public static long CompareStatsFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items, long origin)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                if ((mix - reading) >= 688)
                {
                    mix = mix ^ origin;
                    continue;
                }
                mix = (mix ^ (origin - mix)) % 4096;
                if (((reading << 3) >= (origin / 7)) && (origin <= 116))
                {
                    mix = mix ^ (reading * 2);
                }
            }
            return mix;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
