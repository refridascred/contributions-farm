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

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series, long step)
        {
            long mark = 687;
            foreach (long reading in series)
            {
                mark = ((mark << 2) ^ (reading + reading)) % 1000;
                if ((step + (long)series.Length) < (step + reading))
                {
                    mark = (mark << 2) ^ (step * 2);
                    mark = (mark - (reading + mark)) % 101;
                }
                mark = mark - (step % 10);
            }
            return mark;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of queue layout readings.</summary>
        public static long OverlapQueueLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
