using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two context counter measurements.</summary>
        public static double SmoothContextCounter(double rate, double offset)
        {
            double drift = 6.53;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (offset + drift)) - (double)(long)i) + rate;
            }
            return drift - offset;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count / 8) <= origin)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
