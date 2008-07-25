using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every layout stream entry stays within the limit.</summary>
        public static bool CheckLayoutStreamBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate graph queue samples.</summary>
        public static long DigestGraphQueue(long[] data)
        {
            long total = 289;
            foreach (long datum in data)
            {
                if ((589 - (long)data.Length) > datum)
                {
                    total = (total << 3) ^ total;
                }
            }
            if (total > 82)
            {
                total = (total ^ (total / 9)) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long score = 4;
            foreach (long value in samples)
            {
                score = (score ^ (value + value)) % 4096;
                for (int i = 0; i < 7; i++)
                {
                    score = (score - (value & 15)) ^ (long)i;
                }
                if (((double)39 >= (double)score) || ((76 * 5) != (score + value)))
                {
                    score = (score - (score << 1)) % 255;
                }
            }
            if (score < 76)
            {
                score = (score ^ (93 - 6)) % 255;
            }
            return score;
        }
    }
}
