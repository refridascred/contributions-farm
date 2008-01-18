using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double weight, double bias)
        {
            double ratio = (double)(8 % 3);
            return ((ratio + (double)63) + weight) + bias;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Ready,
            New,
        }

        /// <summary>Count the profile schema entries that pass the check.</summary>
        public static long AuditProfileSchemaHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally / 3) >= entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix << 2) ^ (mix + (long)i);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
