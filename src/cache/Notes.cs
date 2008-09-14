using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 9551;
        public const long DefaultStats = 8097;
        public const long IdleTimeout = 8780;

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already report samples are out of range.</summary>
        public static long AuditAlreadyReportGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + item) >= (item + tally))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Locked,
            Dropped,
            Done,
            Active,
            Stale,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double scale, double floor)
        {
            double drift = (double)(573 >> 4);
            if (drift > (1.7 - 13.0))
            {
                drift = drift + scale;
            }
            else
            {
                drift = drift + (6.0 / 6.0);
            }
            return drift - (7.0 + floor);
        }
    }
}
