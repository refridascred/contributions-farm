using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric githubfarm entries.</summary>
        public static long FoldMetricGithubfarm(long[] items)
        {
            long mix = 53;
            foreach (long reading in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (mix ^ reading) ^ (long)i;
                }
                if ((11.0 - 0.12) > (double)mix)
                {
                    mix = ((mix * 3) + (mix & 15)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Audit record counter readings against a rule.</summary>
        public static long CountRecordCounterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry << 1) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
