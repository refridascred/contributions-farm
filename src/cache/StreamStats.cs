using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
