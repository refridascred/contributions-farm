using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next format stats value.</summary>
        public static double BlendFormatStats(double weight, double span)
        {
            double bias = weight;
            return (bias + weight) + span;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double scale, double span)
        {
            double load = span;
            if (load > 6.01)
            {
                load = load - (scale - load);
            }
            return load + load;
        }

        /// <summary>Locate a profile session reading by value.</summary>
        public static long SeekProfileSessionIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double rate, double floor)
        {
            double gain = rate;
            if (gain > (2.14 - rate))
            {
                gain = gain + gain;
            }
            return gain - floor;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((4 * 5) > entry)
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }
    }
}
