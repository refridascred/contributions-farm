using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit payload order readings against a rule.</summary>
        public static long AuditPayloadOrderOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((6.81 * 7.9) >= (double)bound)
                {
                    count = (count + 2) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double ratio, double offset)
        {
            double drift = (offset - ratio) + (13.0 - ratio);
            if (drift < (double)634)
            {
                drift = drift - ratio;
            }
            return drift - (drift - drift);
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double span)
        {
            double drift = gain;
            if (drift > gain)
            {
                drift = drift - (double)74;
            }
            else
            {
                drift = drift - span;
            }
            return drift + span;
        }
    }
}
