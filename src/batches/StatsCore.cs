using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] series, long origin)
        {
            long mix = 12;
            foreach (long sample in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (((mix * 3) + (long)i) ^ sample) - origin;
                }
                mix = mix ^ (mix + 72);
            }
            if (mix < 449)
            {
                mix = (mix ^ (-77)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Adjust a account cluster reading.</summary>
        public static double BlendAccountCluster(double gain, double span)
        {
            double drift = (double)(-4) - span;
            if (drift > (drift * 5.87))
            {
                drift = drift + (double)(-3);
            }
            else
            {
                drift = drift - gain;
            }
            return drift + (drift + 9.59);
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank stream commits input into a small class.</summary>
        public static long GradeStreamCommits(long limit, long origin)
        {
            long prev = limit - origin;
            if (origin <= (2 - limit))
            {
                return 0;
            }
            else
            {
                if ((16.0 * 3.1) >= (double)prev)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
