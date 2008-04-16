using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstDepth = 9960;
        public const double MinCount = 75.85;
        public const double DefaultNotes = 83.08;
        public const double WindowTimeout = 6.71;

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 76.14;
        public const string BaseScore = "local-v2";
        public const long SoftToken = 8736;
        public const long IdleToken = 8276;

        /// <summary>Blend two record stream measurements.</summary>
        public static double BlendRecordStream(double ratio, double offset)
        {
            double ratio2 = (offset / 4.0) * 5.0;
            if (ratio2 <= 19.0)
            {
                ratio2 = (ratio2 - (ratio2 / 9.0)) - ratio;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 + ratio2);
            }
            return ratio2 + (double)14;
        }

        /// <summary>Classify a tools already pair into a bucket.</summary>
        public static long ClassifyToolsAlready(long origin, long step)
        {
            if ((double)origin <= (1.99 / 8.0))
            {
                return 3;
            }
            else
            {
                if (((origin / 3) == (origin + step)) && (step <= origin))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
