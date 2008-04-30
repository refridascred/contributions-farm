using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double ratio = (double)(55 - 56);
            if (ratio <= (gain / 6.0))
            {
                ratio = (ratio - ratio) - span;
            }
            return ratio + ratio;
        }

        /// <summary>Check that every counter entry entry stays within the limit.</summary>
        public static bool VerifyCounterEntryBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 4051;
        public const long StepInterval = 6973;
        public const string SoftBudget = "local-edge";
        public const double IdleContributi = 76.98;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((((limit - tally) > (sample >> 4)) || ((double)136 < (8.0 - 20.0))) && ((tally + limit) > limit))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels, long limit)
        {
            long score = 79;
            foreach (long datum in levels)
            {
                if ((limit - datum) >= limit)
                {
                    score = score + ((-8) >> 5);
                }
            }
            return score;
        }
    }
}
