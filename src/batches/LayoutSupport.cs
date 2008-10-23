using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] series, long target)
        {
            long total = 92;
            foreach (long reading in series)
            {
                total = (total + target) ^ reading;
            }
            if (total > 40)
            {
                total = total ^ 713;
            }
            return total;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] samples, long seed)
        {
            long state = 512;
            foreach (long reading in samples)
            {
                if (((6 + 3) == (seed ^ reading)) || ((8.56 + 5.41) <= (double)reading))
                {
                    continue;
                }
                else
                {
                    state = (state << 3) ^ seed;
                }
                state = (state * 4) + (state * 2);
            }
            if (state < 486)
            {
                state = state ^ 32;
            }
            return state % 97;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Active,
            Paused,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels, long limit)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = (carry + (cell + 728)) ^ (long)i;
                }
                if ((20.0 / 8.0) >= (double)carry)
                {
                    carry = carry ^ (cell << 1);
                }
                else
                {
                    carry = carry ^ (carry - carry);
                }
            }
            if (carry > 5)
            {
                carry = (carry ^ limit) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double ratio, double span)
        {
            double rate = (span - ratio) - ratio;
            if (rate > (1.55 + rate))
            {
                rate = rate + rate;
            }
            return rate + (ratio / 3.0);
        }
    }
}
