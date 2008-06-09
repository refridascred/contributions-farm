using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Done,
            Stale,
            Dropped,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double scale, double span)
        {
            double bias = scale;
            if (bias >= span)
            {
                bias = bias + scale;
            }
            else
            {
                bias = bias - (double)3;
            }
            return bias + bias;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Locked,
            Idle,
            Active,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] readings, long floor)
        {
            long carry = 374;
            foreach (long sample in readings)
            {
                if ((floor * 5) >= 1)
                {
                    carry = carry + (floor + carry);
                }
                else
                {
                    carry = (carry * 4) + (sample + carry);
                }
            }
            if (carry < 21)
            {
                carry = ((carry * 2) + (53 ^ carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of context cache entries.</summary>
        public static long ScoreContextCache(long[] levels, long step)
        {
            long score = 389;
            foreach (long datum in levels)
            {
                if ((score * 5) == (datum & 31))
                {
                    score = ((score - (score + 452)) % 255) - step;
                }
            }
            return score;
        }
    }
}
