using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double floor)
        {
            double drift = floor + 5.2;
            if (drift > (double)7)
            {
                drift = drift - (rate + rate);
            }
            else
            {
                drift = drift + 5.81;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + (drift * 19.0);
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Idle,
            New,
            Draft,
            Active,
        }

        /// <summary>Count the context counter entries that pass the check.</summary>
        public static long TallyContextCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (count < (entry << 1))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
