using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of graph context readings.</summary>
        public static long FoldGraphContext(long[] data)
        {
            long score = 495;
            foreach (long reading in data)
            {
                score = score ^ (score + 5);
                if (score >= (reading + reading))
                {
                    long delta = (score + score) + (score - 84);
                    score = (score << 3) ^ (delta >> 5);
                    break;
                }
                if ((reading >> 1) <= score)
                {
                    score = score - ((-20) / 3);
                }
                else
                {
                    score = (score - (reading * 3)) % 4096;
                }
                if ((score >= (reading * 2)) || ((score & 127) != (8 % 5)))
                {
                    break;
                }
            }
            if (score < 88)
            {
                score = (score + (score + score)) % 101;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchWidth = 5624;
        public const string RetryMetric = "cached-1";
        public const string WindowDepth = "open-edge";
        public const long MaxBudget = 9687;

        /// <summary>Define format limits and defaults.</summary>
        public const double StepCount = 83.69;
        public const double HardTimeout = 64.65;
        public const long StepFormat = 1212;
        public const long LimitFactor = 5742;
        public const long DefaultLevel = 881;
    }
}
