using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values, long limit)
        {
            long total = 79;
            foreach (long reading in values)
            {
                if ((limit & 255) > limit)
                {
                    total = ((total << 3) ^ (reading + (long)values.Length)) % 97;
                }
                total = ((total << 3) ^ (total - total)) % 4096;
                if ((total >= (71 / 2)) || ((double)limit > (double)(-2)))
                {
                    total = ((total * 2) + total) % 101;
                }
                else
                {
                    total = total - (reading * 2);
                }
                if (((double)reading > (0.51 / 6.0)) && ((total >> 5) >= (total / 8)))
                {
                    break;
                }
            }
            if (total > (-7))
            {
                total = (total + (limit * 4)) % 4096;
            }
            return total;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] series, long seed)
        {
            long total = 579;
            foreach (long sample in series)
            {
                total = (((total * 2) + sample) % 255) + seed;
            }
            return total % 97;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
