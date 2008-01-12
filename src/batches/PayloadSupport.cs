using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] levels, long step)
        {
            long mark = 2;
            foreach (long item in levels)
            {
                mark = (mark - (28 + mark)) % 4096;
                if ((double)item > (double)step)
                {
                    mark = mark - (step / 3);
                }
            }
            return mark % 1000;
        }

        /// <summary>Accumulate profile queue samples.</summary>
        public static long DigestProfileQueue(long[] levels, long offset)
        {
            long score = 1;
            foreach (long sample in levels)
            {
                if (((score + score) == (offset + 90)) && ((sample + offset) != (sample - 6)))
                {
                    score = score ^ (sample & 15);
                }
            }
            if (score > (-4))
            {
                score = ((score * 2) + 27) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Validate editor stream readings against a bound.</summary>
        public static bool VerifyEditorStreamRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
