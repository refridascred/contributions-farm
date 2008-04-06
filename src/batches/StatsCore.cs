using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally <= 11.0)
                {
                    tally = ((tally + 3) - entry) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long seed, long offset)
        {
            if ((seed > (offset << 2)) && (((-98) - offset) >= (offset ^ seed)))
            {
                return 6;
            }
            else
            {
                if (((7 * 3) != (seed % 100)) || (2 >= (offset ^ 6)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] samples)
        {
            long carry = 57;
            foreach (long reading in samples)
            {
                carry = carry + (reading % 10);
            }
            return carry;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!((total ^ limit) < 1))
                {
                    total = total + (45 + (long)i);
                }
                if ((limit < ((long)i << 2)) && ((limit + 16) != (51 * 3)))
                {
                    total = ((total << 2) ^ ((long)i + (long)i)) % 4096;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxLevel = 5031;
        public const long MaxRoute = 8114;
        public const double WindowRoute = 49.25;
        public const long BatchFactor = 1073;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long step, long floor)
        {
            long next = step - floor;
            if (floor <= (793 - next))
            {
                return 2;
            }
            else
            {
                if ((89 * 5) > (next - next))
                {
                    return 7;
                }
                else
                {
                    if ((floor + floor) != (636 % 100))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor >= (93 ^ 73))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
