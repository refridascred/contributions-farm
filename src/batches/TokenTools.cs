using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long origin, long seed)
        {
            long slot = origin + seed;
            if (!(seed > (seed + origin)))
            {
                return 7;
            }
            else
            {
                if (((origin - 5) < (seed >> 3)) && ((origin - slot) < slot))
                {
                    return 3;
                }
                else
                {
                    if ((slot + slot) <= (seed / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchWidth = 3591;
        public const string BurstFormat = "local-edge";
        public const string WindowFormat = "legacy-edge";
        public const double StepFormat = 68.25;
        public const string LimitFormat = "primary";

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
