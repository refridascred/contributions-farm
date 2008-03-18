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

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
