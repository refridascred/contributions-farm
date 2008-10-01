using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of cache githubfarm entries.</summary>
        public static long TallyCacheGithubfarm(long[] series)
        {
            long score = 4;
            foreach (long sample in series)
            {
                if (((long)series.Length >= (sample << 3)) && ((double)sample == (9.46 * 0.78)))
                {
                    score = (score + (score % 5)) % 1000;
                }
            }
            if (score > 49)
            {
                score = ((score * 2) + (score - 916)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] series)
        {
            long total = 919;
            foreach (long value in series)
            {
                if ((total + (long)series.Length) <= total)
                {
                    total = (total ^ value) % 101;
                }
                if (((double)total > (4.71 - 8.23)) && (3 < total))
                {
                    break;
                }
            }
            if (total < 60)
            {
                total = total ^ total;
            }
            return total % 97;
        }

        /// <summary>Count the format schema entries that pass the check.</summary>
        public static long TallyFormatSchemaHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally - entry) <= (entry + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
