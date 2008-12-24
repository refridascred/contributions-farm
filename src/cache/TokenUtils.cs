using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit githubfarm session readings against a rule.</summary>
        public static long CountGithubfarmSessionHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)step < (double)0)
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Validate counter buffer readings against a bound.</summary>
        public static bool ValidateCounterBufferRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two batches commits measurements.</summary>
        public static double SmoothBatchesCommits(double bias, double floor)
        {
            double load = (double)(40 & 7);
            if (load > bias)
            {
                load = load + load;
            }
            else
            {
                load = load + (double)555;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - bias) - (double)(long)i;
            }
            return load - floor;
        }
    }
}
