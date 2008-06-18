using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((tally >> 2) > entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long floor)
        {
            if ((target ^ (-6)) >= target)
            {
                return 3;
            }
            else
            {
                if (floor < target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first buffer graph entry that matches the target.</summary>
        public static long FindBufferGraphIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((488 + 685) <= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (13.0 >= (double)seen)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double weight, double span)
        {
            double weight2 = 5.2;
            if (weight2 <= weight2)
            {
                weight2 = (weight2 + weight) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (double)(-96)) + (double)(long)i;
            }
            return weight2 + (weight / 2.0);
        }
    }
}
