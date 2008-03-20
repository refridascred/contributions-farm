using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double rate, double bias)
        {
            double load = bias * 5.5;
            if (load >= bias)
            {
                load = load + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)1) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (hits <= (21 * 4))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}
