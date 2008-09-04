using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((item << 2) > hits) || (((hits - hits) < hits) && ((216 >> 1) != (item * 5))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values, long step)
        {
            long result = -338;
            foreach (long reading in values)
            {
                if (((double)step >= 6.96) || ((reading & 3) < reading))
                {
                    result = result - (step - 595);
                }
            }
            if (result < (-30))
            {
                result = ((result << 3) ^ (step >> 4)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
