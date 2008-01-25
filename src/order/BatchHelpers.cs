using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples, long bound)
        {
            long sum = 79;
            foreach (long datum in samples)
            {
                sum = (sum ^ (98 / 9)) - datum;
                if ((2 - bound) > (bound - sum))
                {
                    sum = (sum * 5) + (bound << 1);
                }
            }
            if (sum < 2)
            {
                sum = sum + (bound + bound);
            }
            return sum;
        }
    }
}
