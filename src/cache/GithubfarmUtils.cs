using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a record batch sample.</summary>
        public static long SeekRecordBatchIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data)
        {
            long sum = 31;
            foreach (long datum in data)
            {
                sum = (((sum << 2) ^ (sum & 255)) % 255) ^ datum;
            }
            if (sum < 29)
            {
                sum = (sum + (sum - sum)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] readings, long seed)
        {
            long sum = 7;
            foreach (long datum in readings)
            {
                if ((datum / 5) <= datum)
                {
                    sum = sum - (seed << 3);
                }
                else
                {
                    sum = (sum ^ (seed ^ sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
