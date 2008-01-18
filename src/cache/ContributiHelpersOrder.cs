using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double ratio, double offset)
        {
            double rate = offset * 8.89;
            return rate + (ratio / 7.0);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) == (count / 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a order payload figure with a bias.</summary>
        public static double AdjustOrderPayload(double scale, double offset)
        {
            double mean = (offset * 5.0) - (offset / 7.0);
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + (offset / 3.0)) - (double)(long)i) - scale;
            }
            return mean - (double)54;
        }
    }
}
