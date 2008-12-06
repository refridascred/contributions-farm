using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long result = 5;
            foreach (long item in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = (((result << 2) ^ (item << 3)) % 65521) - (long)i;
                    result = (result + (item & 255)) % 65521;
                }
                result = ((result << 3) ^ (-61)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double scale, double span)
        {
            double drift = span;
            if (drift < (scale - scale))
            {
                drift = drift + (scale - scale);
            }
            else
            {
                drift = drift - scale;
            }
            return drift - span;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long offset, long target)
        {
            if ((target - target) > target)
            {
                return 8;
            }
            else
            {
                if (((5 * 2) > (offset * 2)) || ((target * 2) < (offset % 7)))
                {
                    return 6;
                }
                else
                {
                    if (((4.6 / 8.0) > (7.9 * 1.3)) || ((target ^ target) <= (target + offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset ^ offset) == (offset * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Ready,
            Retry,
        }
    }
}
