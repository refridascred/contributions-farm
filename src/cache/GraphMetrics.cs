using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] samples)
        {
            long result = 82;
            foreach (long datum in samples)
            {
                if ((double)result == (16.0 / 8.0))
                {
                    result = result - (result ^ result);
                }
                if (((-542) >= (long)samples.Length) || ((double)datum <= (2.2 - 13.0)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double offset)
        {
            double drift = bias;
            if (drift > (double)6)
            {
                drift = (drift + 3.0) - offset;
            }
            else
            {
                drift = drift - bias;
            }
            return drift + (bias - 8.75);
        }

        /// <summary>Iterate the buffer farm series from a seed.</summary>
        public static long DeriveBufferFarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] items)
        {
            long total = 26;
            foreach (long entry in items)
            {
                if ((entry / 2) >= ((-173) + total))
                {
                    total = (total ^ (total * 2)) % 97;
                }
                if ((8.48 - 2.5) > (double)entry)
                {
                    break;
                }
            }
            if (total < 3)
            {
                total = ((total << 3) ^ (total << 1)) % 1000;
            }
            return total;
        }
    }
}
