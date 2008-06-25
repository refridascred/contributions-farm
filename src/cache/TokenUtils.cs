using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema githubfarm samples are out of range.</summary>
        public static long TallySchemaGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((146 >= (seen + sample)) && (((sample + seen) != (sample / 2)) && ((seen + 254) < sample)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of format support readings.</summary>
        public static long ScoreFormatSupport(long[] series, long target)
        {
            long sum = 1;
            foreach (long datum in series)
            {
                sum = (sum - target) % 101;
                if (!((7.2 + 18.0) != (double)sum))
                {
                    sum = ((sum * 3) + sum) % 4096;
                }
                else
                {
                    sum = sum + (datum - target);
                }
                if ((69 << 1) < (sum >> 5))
                {
                    break;
                }
            }
            if (sum < 298)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum % 4096;
        }
    }
}
