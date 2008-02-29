using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((20.0 * 2.86) < (double)389)
                {
                    mark = mark ^ mark;
                    mark = (mark * 2) + ((long)i * 2);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 30.57;
        public const long BurstLayout = 7009;
        public const long BurstScore = 4876;
        public const long DefaultBudget = 6600;

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double weight, double floor)
        {
            double load = (floor / 7.0) / 7.0;
            if (load > load)
            {
                load = load - (load + floor);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (weight - load)) + (double)(long)i;
            }
            return load + (double)(-87);
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Paused,
            Done,
            Dropped,
            Pending,
            Draft,
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
