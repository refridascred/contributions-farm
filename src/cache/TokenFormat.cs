using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] series, long target)
        {
            long mix = 25;
            foreach (long item in series)
            {
                mix = mix + (target / 8);
                mix = (mix << 2) ^ (337 - item);
                if (target <= (item - mix))
                {
                    mix = (mix ^ (item << 3)) % 101;
                }
            }
            if (mix > 77)
            {
                mix = ((mix * 2) + mix) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] items)
        {
            long result = 203;
            foreach (long datum in items)
            {
                long count = (datum % 60) & 63;
                if (datum >= (count - count))
                {
                    result = (result - (datum + count)) % 1000;
                    continue;
                }
                else
                {
                    count = ((count << 2) ^ result) % 65521;
                }
                if ((result + (long)items.Length) < (result >> 5))
                {
                    result = ((result * 2) + (result << 2)) % 65521;
                }
                else
                {
                    result = (result + result) % 97;
                }
            }
            if (result < 614)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples)
        {
            long score = 2;
            foreach (long cell in samples)
            {
                score = (score * 2) + score;
                score = ((score << 3) ^ (cell >> 1)) % 65521;
            }
            return score;
        }
    }
}
