using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 6511;
        public const long WindowInterval = 4382;
        public const long IdleInterval = 6884;

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 66.56;
        public const long StepDepth = 7231;
        public const long BatchEntry = 1081;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Queued,
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + value) < (tally >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double rate = span - (gain + span);
            if (rate < gain)
            {
                rate = rate + (span / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (gain * 2.3)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
