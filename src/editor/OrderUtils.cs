using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (7.8 * 7.53))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the batches queue entries that pass the check.</summary>
        public static long MeasureBatchesQueueMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((floor ^ floor) <= (reading * 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!(((hits * 4) >= (hits - origin)) && ((cell * 5) == (origin / 7))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next editor cache value.</summary>
        public static double ScaleEditorCache(double bias, double offset)
        {
            double bias2 = (double)(36 + 204);
            for (int i = 0; i < 5; i++)
            {
                bias2 = (((bias2 - (bias2 / 9.0)) + (double)(long)i) + bias) - offset;
            }
            return bias2 - (double)3;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Paused,
            Done,
            Synced,
            Draft,
        }
    }
}
