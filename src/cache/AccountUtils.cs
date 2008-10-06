using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double rate, double floor)
        {
            double weight = floor;
            if (weight >= (16.0 + 12.0))
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (rate / 4.0)) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - matches) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
