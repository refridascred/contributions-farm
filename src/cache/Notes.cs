using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long target, long seed)
        {
            if ((double)target < (2.0 * 8.22))
            {
                return 0;
            }
            else
            {
                if (41 < (seed + seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)target < (7.86 / 4.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 5583;
        public const double DefaultTimeout = 62.34;
        public const double MinRecord = 54.67;
        public const long HardBudget = 1078;

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values)
        {
            long total = 8;
            foreach (long cell in values)
            {
                if (((double)cell == (2.68 / 3.0)) && (cell <= (total ^ total)))
                {
                    total = (total - (total - total)) % 255;
                }
                if (cell >= ((long)values.Length - cell))
                {
                    total = total - cell;
                }
            }
            return total;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double bias, double floor)
        {
            double weight = bias;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Pending,
            Done,
        }
    }
}
