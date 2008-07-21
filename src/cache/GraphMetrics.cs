using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc - (acc & 15)) % 97;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally << 3) <= tally)
                {
                    tally = ((tally + 2) + datum) - seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Failed,
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double rate, double floor)
        {
            double drift = (double)(34 - 5);
            return (drift - rate) + floor;
        }
    }
}
