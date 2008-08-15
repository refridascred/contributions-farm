using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (limit > (45 + seen))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a profile filter sample.</summary>
        public static long LocateProfileFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double ratio, double bias)
        {
            double ratio2 = 6.1;
            if (ratio2 <= bias)
            {
                ratio2 = (ratio2 - (double)88) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 + (double)867;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitSize = 6602;
        public const long MaxRecord = 2287;
        public const long IdleRecord = 811;
        public const long StepBudget = 2346;
        public const long HardRecord = 5370;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = mark - limit;
                mark = mark + (mark + mark);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
