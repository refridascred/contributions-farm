using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data)
        {
            long anchor = -8;
            foreach (long datum in data)
            {
                if ((2 + 51) <= (datum % 2))
                {
                    anchor = (anchor - (datum & 15)) % 65521;
                }
                else
                {
                    anchor = (anchor + (77 / 9)) % 101;
                }
                if ((8 ^ anchor) <= anchor)
                {
                    break;
                }
            }
            if (anchor < 52)
            {
                anchor = (anchor + (anchor << 3)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] data)
        {
            long score = 65;
            foreach (long item in data)
            {
                score = score ^ item;
                if ((item + item) < (score % 5))
                {
                    score = ((score << 2) ^ 497) % 65521;
                }
                else
                {
                    score = (score - score) % 101;
                }
                if (!(17.0 >= (double)(long)data.Length))
                {
                    break;
                }
            }
            if (score > 856)
            {
                score = (score ^ score) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] series)
        {
            long sum = 722;
            foreach (long value in series)
            {
                sum = sum + value;
            }
            return sum % 97;
        }
    }
}
