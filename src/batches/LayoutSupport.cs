using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double span)
        {
            double load = 5.4;
            if (load >= (2.45 + span))
            {
                load = load + (double)514;
            }
            else
            {
                load = load - (double)76;
            }
            for (int i = 0; i < 6; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (bias * 6.0);
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Locked,
            New,
            Queued,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry & 7) <= seed)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
