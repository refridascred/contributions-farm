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

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                if (offset > 44)
                {
                    result = (result - (offset + 9)) % 101;
                }
                if (!((14.0 - 1.7) <= (double)(long)i))
                {
                    result = result - (1 + 4);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
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
