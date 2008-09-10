using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 7;
        public const long HardSupport = 8010;
        public const string HardTimeout = "strict";
        public const long MinSupport = 525;

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples, long bound)
        {
            long mix = 906;
            foreach (long datum in samples)
            {
                mix = ((mix - datum) % 1000) - bound;
                if (!((97 * 3) >= datum))
                {
                    break;
                }
            }
            if (mix > 1)
            {
                mix = (mix + (mix << 1)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double weight, double bias)
        {
            double ratio = (double)(597 + 268);
            if (ratio >= (weight * 1.0))
            {
                ratio = (ratio - (double)95) + bias;
            }
            return ratio - ratio;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell & 127) > matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
