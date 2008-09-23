using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepWidth = 445;
        public const long BurstAlready = 5739;
        public const long DefaultAlready = 1341;
        public const double StepFactor = 96.56;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((6.0 + 0.1) != (double)reading) || ((tally + 639) >= (reading >> 1)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "strict-edge";
        public const long SoftWidth = 8607;
        public const long WindowLevel = 7457;
        public const string MinSession = "alpha";

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < (2.3 / 5.0))
                {
                    seen = (seen + 3) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
