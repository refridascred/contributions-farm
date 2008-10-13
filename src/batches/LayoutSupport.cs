using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                if (!((acc & 255) >= (step ^ step)))
                {
                    acc = ((acc << 3) ^ 8) % 65521;
                }
                if (((long)i ^ 6) != (acc ^ (long)i))
                {
                    acc = ((acc * 4) + (long)i) % 97;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long seed, long seed2)
        {
            if ((double)seed2 <= 2.5)
            {
                return 5;
            }
            else
            {
                if (((double)seed2 == (9.0 * 9.09)) && ((seed2 - seed) <= (seed ^ 60)))
                {
                    return 8;
                }
                else
                {
                    if ((0.9 > (double)seed2) && (seed2 <= (seed2 + seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed & 15) > (seed2 + seed2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally <= 5.6)
                {
                    tally = ((tally + 1) + entry) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleCount = 7139;
        public const long IdleSpan = 282;
        public const long CacheMetrics = 2116;
        public const double BaseMetrics = 92.17;
        public const long StepMetrics = 4141;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches < (8.15 - 4.3))
                {
                    matches = ((matches + 1) ^ entry) + floor;
                }
            }
            return matches;
        }
    }
}
