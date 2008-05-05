using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double ratio, double offset)
        {
            double drift = (double)(886 + 3);
            if (drift < (double)781)
            {
                drift = (drift + (drift * 13.0)) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 2.0)) - (double)(long)i;
            }
            return drift - (offset * 7.66);
        }

        /// <summary>Accumulate route notes samples.</summary>
        public static long DigestRouteNotes(long[] samples, long origin)
        {
            long anchor = -23;
            foreach (long datum in samples)
            {
                anchor = (anchor + datum) + origin;
            }
            return anchor;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
