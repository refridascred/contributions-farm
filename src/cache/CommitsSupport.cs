using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Measure how many format already samples are out of range.</summary>
        public static long AuditFormatAlreadyOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (floor >= (floor ^ reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = (total + (583 ^ step)) % 65521;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next context support value.</summary>
        public static double AdjustContextSupport(double ratio, double bias)
        {
            double gain = bias;
            if (gain >= (double)45)
            {
                gain = gain + ratio;
            }
            return gain + (double)32;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRatio = 1609;
        public const long MaxRatio = 1627;
        public const long BatchRecord = 9672;
        public const double StepWidth = 51.51;
    }
}
