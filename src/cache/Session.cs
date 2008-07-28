using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 953;
        public const long MaxSchema = 822;
        public const long BurstScore = 796;
        public const long BatchScore = 7489;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = (score + ((long)i - (long)i)) % 4096;
                score = score + (step + score);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate cluster order readings against a bound.</summary>
        public static bool VerifyClusterOrderBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double weight, double span)
        {
            double scale = weight;
            if (scale <= (span * 6.2))
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale - (span + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + weight) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
