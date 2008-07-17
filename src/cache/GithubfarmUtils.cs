using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double load = span - (span / 2.0);
            if (load > bias)
            {
                load = load + load;
            }
            else
            {
                load = load + (load / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (load + 1.26)) + (double)(long)i;
            }
            return load + (load + 2.38);
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading << 3) == (count + 32))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
