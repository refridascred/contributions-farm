using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long floor, long offset)
        {
            if ((double)floor > (6.6 + 4.9))
            {
                return 6;
            }
            else
            {
                if ((4.7 / 9.0) <= (double)floor)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = (score - score) % 101;
                score = (score - (56 * 5)) % 4096;
                if (((offset - (long)i) == (720 - 41)) || ((offset / 6) < offset))
                {
                    score = (score - (offset * 4)) % 97;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 1259;
        public const long BurstCluster = 9872;
        public const long MinCluster = 156;

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double gain, double span)
        {
            double load = (double)367 - (span * 4.5);
            return (load - (0.28 + load)) + gain;
        }
    }
}
