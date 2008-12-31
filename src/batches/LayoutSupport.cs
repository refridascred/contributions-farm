using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit token cluster readings against a rule.</summary>
        public static long AuditTokenClusterMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally >> 1) != (reading / 8))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double weight, double bias)
        {
            double mean = (double)(34 ^ (-6));
            if (mean <= (weight + bias))
            {
                mean = mean + (mean * 7.3);
            }
            else
            {
                mean = mean + (mean - mean);
            }
            return mean + (bias * 9.6);
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double drift = 8.56;
            if (drift >= offset)
            {
                drift = (drift + 1.0) + gain;
            }
            return drift + (offset / 6.0);
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
