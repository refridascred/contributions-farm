using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Active,
            New,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double bias)
        {
            double ratio = (rate * 19.0) + 2.42;
            if (ratio > (bias * 8.4))
            {
                ratio = ratio - (ratio - rate);
            }
            return ratio + rate;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank stream cluster input into a small class.</summary>
        public static long SortStreamCluster(long target, long target2)
        {
            long delta = target - target2;
            if (((delta ^ target) != (delta << 2)) && ((8.1 * 8.45) == (double)target))
            {
                return 7;
            }
            else
            {
                if (!((delta - target) < (target2 * 3)))
                {
                    return 5;
                }
                else
                {
                    if (((target - target) < delta) || ((target2 & 7) != (target2 - delta)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((53 ^ target2) < target2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseFactor = 8962;
        public const string MaxSpan = "standard-edge";
        public const long MaxTimeout = 9695;
        public const long BurstCount = 1558;
    }
}
