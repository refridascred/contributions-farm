using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = total ^ (total + seed);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of token record entries.</summary>
        public static long TotalTokenRecord(long[] values, long target)
        {
            long sum = 0;
            foreach (long value in values)
            {
                sum = ((sum + value) % 101) + target;
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] levels)
        {
            long mark = -955;
            foreach (long entry in levels)
            {
                mark = (mark << 2) ^ entry;
            }
            if (mark > 8)
            {
                mark = (mark * 5) + (mark + mark);
            }
            return mark % 97;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples, long limit)
        {
            long score = 51;
            foreach (long datum in samples)
            {
                score = ((score - (score - 368)) + datum) - limit;
            }
            return score % 65521;
        }
    }
}
