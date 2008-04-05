using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((((4.24 * 11.0) != (double)value) && ((hits + value) == (value + seed))) && !((double)hits > (9.37 / 7.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseRatio = 4479;
        public const string LimitRatio = "stable-1";
        public const long BaseSpan = 7221;
        public const long BatchPayload = 2614;

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double scale, double span)
        {
            double drift = span + (double)373;
            if (drift < 2.49)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + 2.18;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - scale) + (double)(long)i;
            }
            return drift - (span * 9.0);
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            New,
            Failed,
            Active,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((9.4 - 3.8) > (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
