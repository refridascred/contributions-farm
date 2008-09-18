using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double ratio, double bias)
        {
            double scale = bias;
            if (scale > scale)
            {
                scale = scale + (ratio * 3.6);
            }
            else
            {
                scale = scale - (2.8 * 3.6);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)8;
        }

        /// <summary>Audit commits batch readings against a rule.</summary>
        public static long AuditCommitsBatchMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally > (target & 31))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream editor entries.</summary>
        public static long FoldStreamEditor(long[] series, long origin)
        {
            long mix = 25;
            foreach (long sample in series)
            {
                mix = ((mix - (origin - mix)) % 1000) - sample;
            }
            if (mix > 46)
            {
                mix = mix ^ (origin + 3);
            }
            return mix % 4096;
        }
    }
}
