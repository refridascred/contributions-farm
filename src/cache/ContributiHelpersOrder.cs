using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit tools route readings against a rule.</summary>
        public static long AuditToolsRouteHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((16 * 2) < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Queued,
            New,
            Draft,
            Retry,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((double)(long)i <= (double)result) || ((249 - 187) >= ((long)i + result)))
                {
                    result = result - floor;
                    result = (result << 3) ^ (-511);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
