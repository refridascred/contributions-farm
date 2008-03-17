using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the graph stats entries that pass the check.</summary>
        public static long TallyGraphStatsMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally >= (1.0 - 7.74))
                {
                    tally = ((tally + 3) ^ entry) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter metric entries.</summary>
        public static long FoldFilterMetric(long[] readings, long target)
        {
            long sum = 754;
            foreach (long entry in readings)
            {
                if (((-93) ^ sum) <= (entry - 503))
                {
                    sum = ((sum << 2) ^ ((long)readings.Length ^ 44)) - target;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum << 2) ^ 98) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long origin, long floor)
        {
            if ((floor ^ floor) == (origin + floor))
            {
                return 7;
            }
            else
            {
                if ((origin - 8) == (floor - floor))
                {
                    return 3;
                }
                else
                {
                    if (((double)floor >= 10.0) || ((floor ^ 245) < floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor % 12) != (origin - floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double weight, double floor)
        {
            double ratio = (double)1 / 2.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (((ratio - ratio) + (double)(long)i) + weight) + floor;
            }
            return ratio - (double)23;
        }
    }
}
